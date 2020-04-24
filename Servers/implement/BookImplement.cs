using Dapper;
using Microsoft.Extensions.Options;
using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servers.implement
{
    public class BookImplement : BookInterface
    {
        public readonly string LinkSQL;

        //重写构造函数，包含注入的配置信息
        public BookImplement(IOptions<SQLConnection> conection)
        {
            LinkSQL = conection.Value.Connecting;
        }

        public async Task<int> AddCollect(Collect collect)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[Collect] ([userid],[booksid]) VALUES (@userid,@booksid)";
                var result = await db.ExecuteAsync(sql, collect);
                return result;
            }
        }

        public async Task<int> AddOpinion(Opinion opinion)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[opinion] ([userid],[username],[content]) VALUES (@userid,@username,@content)";
                var result = await db.ExecuteAsync(sql, opinion);
                return result;
            }
        }

        public async Task<int> addValuations(Valuation valuation)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[valuation] ([booksid],[content],[userName]) VALUES (@booksid,@content,@userName)";
                var result = await db.ExecuteAsync(sql, valuation);
                return result;
            }
        }

        public async Task<Admin> AdminLogin(string accout, string password)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<Admin>($@"select * from  [dbo].[admin] where account='{accout}' and password ='{password}'");
                return result;
            }
        }

        public async Task<int> DelUser(int userid)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"delete from [User] where id='{userid}'";
                var result = await db.ExecuteAsync(sql);
                return result;
            }
        }

        public async Task<List<Books>> GetBooks(Books Books)
        {
            var where = new StringBuilder();
            var sql = new StringBuilder();
            if (Books.title != null && Books.title != "")
            {
                where.Append($" and [title] like '%{Books.title}%'");
            }
            else if (Books.Types != 0)
            {
                where.Append($" and [Types]={Books.Types}");
            }
            
            sql.Append($@"select * from books where 1=1 {where}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql.ToString()))
                    {
                        var datalist = multi.Read<Books>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<Collect> getCollect(Collect collect)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<Collect>($@"select * from  Collect where userid='{collect.userid}' and  booksid='{collect.booksid}'");
                return result;
            }
        }
         

        public async Task<List<Opinion>> GetOpinions()
        {
            string sql = "select * from opinion";
            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql))
                    {
                        var datalist = multi.Read<Opinion>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }

        }

        public async Task<Books> getTheBooks(int bookid)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<Books>($@"select * from books where id={bookid}");
                return result;
            }
        }

        public async Task<List<BooksDTO>> getUserBooks(int userid)
        { 
            
            string sql=($@"select b.title,b.author,b.id from books as b inner join Collect  as c on b.id=c.booksid  inner join [User] as u on 
u.id=c.userid where c.userid={userid}");

            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql))
                    {
                        var datalist = multi.Read<BooksDTO>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<List<User>> getUsers()
        {
            string sql = $@"select * from [User]";
            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql))
                    {
                        var datalist = multi.Read<User>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<List<Valuation>> GetValuations(int booksid)
        {
            string sql = $@"select * from valuation where booksid ='{booksid}'";
            using (var db = new SqlConnection(LinkSQL))
            {
                try
                {
                    using (var multi = await db.QueryMultipleAsync(sql))
                    {
                        var datalist = multi.Read<Valuation>().ToList();
                        return datalist;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public async Task<int> registered(User user)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[User] ([account],[password],[userName]) VALUES (@account,@password,@userName)";
                var result = await db.ExecuteAsync(sql, user);
                return result;
            }
        }

        public async Task<int> Updatebooks(int booksid)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.ExecuteAsync("update books set collection =collection+1 where id='"+booksid+"'");
                return result;
            }
        }

        public async Task<User> UserLogin(string accout, string password)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.QuerySingleOrDefaultAsync<User>($@" select * from  [dbo].[User] where account='{accout}' and password ='{password}'");
                return result;
            }
        }

        public async Task<int>  UpdatebooksStatus(int booksid)
        {
            
            using (var db = new SqlConnection(LinkSQL))
            {
                var result = await db.ExecuteAsync("update books set status=(CASE WHEN status = 1 THEN '0' ELSE '1' END ) where id='" + booksid + "'");
                return result;
            }
        }

        public async Task<int> Addbooks(Books books)
        {
            using (var db = new SqlConnection(LinkSQL))
            {
                var sql = $@"INSERT INTO [dbo].[books] ([title],[summary],[author],[addedTime],[imgUrl],[Types],[txtUrl]) VALUES (@title,@summary,@author,@addedTime,@imgUrl,@Types,@txtUrl)";
                var result = await db.ExecuteAsync(sql, books);
                return result;
            }
        }
    }
}

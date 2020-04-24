using Model;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Servers
{
    public interface BookInterface
    {

        //管理员登录
        Task<Admin> AdminLogin(string accout, string password);
        //用户登录
        Task<User> UserLogin(string accout, string password);
        //用户注册
        Task<int> registered(User user);
        //查询书籍
        Task<List<Books>> GetBooks(Books knowledge);
        //查询单个书籍
        Task<Books> getTheBooks(int bookid);
        //查询网站评论
        Task<List<Opinion>> GetOpinions();
        //查询书的评价
        Task<List<Valuation>> GetValuations(int booksid);
        //用户进行评价书籍
        Task<int> addValuations(Valuation valuation);
        //用户进行收藏
        Task<int> AddCollect(Collect collect);
        //查询用户收藏书籍
        Task<List<BooksDTO>> getUserBooks(int userid);
        //判断是否删除
        Task<Collect> getCollect(Collect collect);
        //修改收藏
        Task<int> Updatebooks(int booksid);
        //用户评价网站
        Task<int> AddOpinion(Opinion opinion);
        //查询所有用户
        Task<List<User>> getUsers();
        //删除用户
        Task<int> DelUser(int userid);
        //下架或上架书籍 
        Task<int> UpdatebooksStatus(int booksid);
        //上传书籍
        Task<int> Addbooks(Books books);
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Model;
using OnlineBookstore.Models;
using Servers;

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BookInterface _bookInterface;

        public HomeController(ILogger<HomeController> logger, BookInterface BookImplement)
        {
            _logger = logger;
            _bookInterface = BookImplement;
        }

        /// <summary>
        /// 设置Session
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        protected void SetSession(string key, string value)
        {
            HttpContext.Session.SetString(key, value);
        }

        /// <summary>
        /// 获取Session
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回对应的值</returns>
        protected string GetSession(string key)
        {
            var value = HttpContext.Session.GetString(key);
            if (string.IsNullOrEmpty(value))
                value = string.Empty;
            return value;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            if (GetSession("username") == "")
            {
                Response.Redirect("/Home/Login");
            }
            return View();
        }

         [HttpGet]
        public async Task<JsonResult> getUserBooks(int userId)
        {
            var result = await _bookInterface.getUserBooks(userId);
            return Json(result);
        }

        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> login(string account, string password)
        {
            var result = new object();
            if (account == "admin")
            {
                result = await _bookInterface.AdminLogin(account, password);
            }
            else
            {
                result = await _bookInterface.UserLogin(account, password);
            }
            if (result != null)
            {
                SetSession("username", account);
            }
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> registered(User user)
        {
            var result = await _bookInterface.registered(user);
            return Json(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetBooks(Books books)
        {
            var result = await _bookInterface.GetBooks(books);
            return Json(result);
        }
        [HttpGet]
        public async Task<JsonResult> GetTheBooks(int booksid)
        {
            var result = await _bookInterface.getTheBooks(booksid);
            return Json(result);
        }
        public async Task<JsonResult> GetValuations(int booksid)
        {
            var result = await _bookInterface.GetValuations(booksid);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> addValuations(Valuation valuation)
        {
            var result = await _bookInterface.addValuations(valuation);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> AddOpinion(Opinion opinion)
        {
            var result = await _bookInterface.AddOpinion(opinion);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> AddCollect(Collect collect)
        {
            var result = await _bookInterface.AddCollect(collect);
            return Json(result);
        }
        [HttpGet]
        public async Task<JsonResult> getCollect(Collect collect)
        {
            var result = await _bookInterface.getCollect(collect);
            return Json(result);
        }
        [HttpPost]
        public async Task<JsonResult> updatebooks(int booksid)
        {
            var result = await _bookInterface.Updatebooks(booksid);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> DelUser(int userId)
        {
            var result = await _bookInterface.DelUser(userId);
            return Json(result);
        }
        [HttpGet]
        public async Task<JsonResult> GetUsers()
        {
            var result = await _bookInterface.getUsers();
            return Json(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetOpinions()
        {
            var result = await _bookInterface.GetOpinions();
            return Json(result);
        }
        [HttpPost]
        public async Task<JsonResult> UpdatebooksStatus(int booksid)
        {
            var result = await _bookInterface.UpdatebooksStatus(booksid);
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> Addbooks(Books books)
        {
            books.addedTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var result = await _bookInterface.Addbooks(books);
            return Json(result);
        }
        public IActionResult Opinion()
        {
            if (GetSession("username") == "")
            {
                Response.Redirect("/Home/Login");
            }
            return View();
        }
        public IActionResult Seedetails()
        {
            return View();
        }
        public IActionResult Management()
        {
            if (GetSession("username") == "")
            {
                Response.Redirect("/Home/Login");
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]　　　　//上传文件是 post 方式，这里加不加都可以
        public async Task<bool> UploadFiles(IFormFile files)
        {
            string filepath = Directory.GetCurrentDirectory();
            if (files.ContentType.IndexOf("image") == 0)
            {
                filepath += "\\wwwroot\\img";  //存储文件的路径
            }
            else
            {
                filepath += "\\wwwroot\\text";
            }
            

            var thispath = filepath + "\\" + files.FileName;     //当前上传文件应存放的位置
           
            if (System.IO.File.Exists(thispath) != true && files.Length>0)        //如果文件已经存在,跳过此文件的上传
            {
                //上传文件
                using (var stream = new FileStream(thispath, FileMode.Create))      //创建特定名称的文件流
                {
                    try
                    {
                        await files.CopyToAsync(stream);     //上传文件
                        return true;
                    }
                    catch (Exception ex)        //上传异常处理
                    {
                        ViewBag.log += "\r\n" + ex.ToString();
                       
                    }
                }
            }
             return false;
        }
    }
}

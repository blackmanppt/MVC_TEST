using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TEST.Models;
using MVC_TEST.Services;
namespace MVC_TEST.Controllers
{
    public class MessageController : Controller
    {
        messageDBService data = new messageDBService();
        // GET: Message
        public ActionResult Index()
        {
            return View(data.GetData());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(string Article_title,string Content)
        {
            //塞入資料庫
            data.DBCreate(Article_title, Content);
            return RedirectToAction("Index");
        }
    }
}
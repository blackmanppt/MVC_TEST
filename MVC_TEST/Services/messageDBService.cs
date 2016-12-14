using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_TEST.Models;
namespace MVC_TEST.Services
{
    public class messageDBService
    {
        public MVC_TEST.Models.messageEntities db = new Models.messageEntities();

        public List<Article> GetData()
        {
            return (db.Article.ToList());
        }
        public void DBCreate(string Article_title,string Content)
        {
            Article NewData = new Article();
            NewData.Title = Article_title;
            NewData.Content = Content;
            NewData.time = DateTime.Now;
            db.Article.Add(NewData);
            db.SaveChanges();
        }
    }
}
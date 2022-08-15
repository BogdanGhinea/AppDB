using AppDatenB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDatenB.Controllers
{
    public class HomeController : Controller
    {
        private NewsApplicationContext ctx;
        public HomeController(NewsApplicationContext ctx)
        {
            this.ctx = ctx;
        }

        public IActionResult Index()
        {            
            return View(ctx.Articles.ToList());
        }
        [HttpGet]
        public IActionResult NewArticle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewArticle(Article article)
        {
            article.Created = DateTime.Now;
            int maxId = 0;
            if (ctx.Articles.Any())
            {
                maxId = ctx.Articles.Max(a => a.Id);
            }
            article.Id = maxId + 1;
            ctx.Add(article);
            ctx.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

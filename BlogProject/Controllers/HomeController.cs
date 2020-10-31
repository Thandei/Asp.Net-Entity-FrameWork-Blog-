using BlogProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        private BlogContext db = new BlogContext();
        public ActionResult Index()
        {
             
             
            return View(db.Bloglar.ToList());
        }
    }
}
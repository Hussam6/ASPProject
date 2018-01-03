using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models;

namespace Project.Controllers
{
    public class HomeController : Controller
    {

       

        //Get
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        [HttpPost]
        public ActionResult Index(LoginController loginController)
        {
            ViewBag.Message = "Your contact page.";
            


            return View();
        }
    }
}
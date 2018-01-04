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

        [Authorize]
        public ActionResult Welcome(LoginController loginController)
        {
            //ViewBag.Message = "Your contact page.";
            


            return View();
        }
    }
}
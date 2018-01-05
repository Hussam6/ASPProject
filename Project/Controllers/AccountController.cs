using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project.Models.ViewModel;
using Project.Models.EntityManager;


namespace Project.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserSignUpView USV) {


            if (ModelState.IsValid) {

                UserManager um = new UserManager();
                um.addUserAccount(USV);
                return RedirectToAction("Welcome", "Home");




            }

            else
            {
                ModelState.AddModelError("", "Error Occured");

            }

            return View();

        }
    }


}
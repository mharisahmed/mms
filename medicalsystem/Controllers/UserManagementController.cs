using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;
using System.Web.Security;

namespace medicalsystem.Controllers
{
    public class UserManagementController : Controller
    {
        // GET: UserManagement
        //use allow anonymous to for skip role checking
        [AllowAnonymous]
        public ActionResult Index()
        {  
            return View();
        }
        //use allow anonymous to for skip role checking
       [AllowAnonymous]
        [HttpPost]
        public ActionResult Index(string txtusername, string txtpass)
        {
            if (DataServices.Services.LoginService.Instance.LoginAuth(txtusername, txtpass)) {
                Session["Logged_in"] = true;
                FormsAuthentication.SetAuthCookie(txtusername, false);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Error = "Invalid Username or Password!";
                return View();
                //return RedirectToAction("Index", "UserManagement");
            }         
        }



    }
}
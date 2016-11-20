using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //use allow anonymous to for skip role checking
        [AllowAnonymous]
        public ActionResult Index()
        { 
    
            return View();
        }
    }
}
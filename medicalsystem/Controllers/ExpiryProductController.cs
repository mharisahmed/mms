using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace medicalsystem.Controllers
{
    public class ExpiryProductController : Controller
    {
        // GET: ExpiryProduct
        public ActionResult Index()
        {
            return View(DataServices.Services.ExpiryPorduct.Instance.RecievedMasterDetail());
        }
    }
}
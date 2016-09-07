using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace medicalsystem.Controllers
{
    public class ProductRecievedController : Controller
    {
        // GET: ProductRecieved
        public ActionResult Index()
        {

            return View(DataServices.Services.RecievedProduct.Instance.RecievedMasterDetails());
        }

        
        [HttpGet]
        // Get Detail Of Master Recieved.
        public ActionResult Details(int id)
        {
            ViewBag.getproductlist = new SelectList(DataServices.Services.RecievedProduct.Instance.listofProduct(), "ProductId", "ProductName");
            return View(DataServices.Services.RecievedProduct.Instance.RecievedDetails(id));
        }
    }
}
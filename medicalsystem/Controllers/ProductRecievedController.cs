using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;
using medicalsystem.Models;

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

        [HttpGet]
        // Get Detail Of Master Recieved.
        public ActionResult Create()
        {

            ViewBag.getDealer = new SelectList(DataServices.Services.RecievedProduct.Instance.listofDealers(), "DealId", "DealerName");
            ViewBag.getProduct = new SelectList(DataServices.Services.RecievedProduct.Instance.listofProduct(), "ProductId", "ProductName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductRecieved prec)
        {

            
            return RedirectToAction("Index");
        }
    }
}
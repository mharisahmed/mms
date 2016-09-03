using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View(DataServices.Services.ProductService.Instance.getproducts());
           
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.gettypes = new SelectList(DataServices.Services.ProductService.Instance.listoftypes(), "TypeId", "TypeName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblProduct product)
        {
            DataServices.Services.ProductService.Instance.AddProduct(product);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var getCompanyForEdit = DataServices.Services.ProductService.Instance.EditProduct(id);
            ViewBag.gettypes = new SelectList(DataServices.Services.ProductService.Instance.listoftypes(), "TypeId", "TypeName");
            return View(getCompanyForEdit);
        }

        [HttpPost]
        public ActionResult Edit(tblProduct prod,int id)
        {
            DataServices.Services.ProductService.Instance.UpdateProduct(prod,id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult delete(int id)
        {
            DataServices.Services.ProductService.Instance.DeleteProduct(id);
            return RedirectToAction("index");
        }
    }
}
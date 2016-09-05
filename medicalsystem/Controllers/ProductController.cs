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
        [AllowAnonymous]
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

        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var getCompanyForEdit = DataServices.Services.CompanyService.Instance.EditCompany(id);
        //    return View(getCompanyForEdit);
        //}

        //[HttpPost]
        //public ActionResult Edit(tblCompay comp)
        //{
        //    DataServices.Services.CompanyService.Instance.UpdateCompany(comp);
        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
        //    DataServices.Services.CompanyService.Instance.DeleteCompany(id);
        //    return RedirectToAction("Index");
        //}
    }
}
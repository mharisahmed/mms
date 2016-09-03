using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class DealersController : Controller
    {
        // GET: Dealers
        public ActionResult Index()
        {
            return View(DataServices.Services.DealersService.Instance.getdealers());
        }


        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.getCompany = new SelectList(DataServices.Services.DealersService.Instance.listofCompanies(), "CompanyId", "CompanyName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblDealer dealer)
        {
            DataServices.Services.DealersService.Instance.AddDealer(dealer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var getDealerForEdit = DataServices.Services.DealersService.Instance.EditDealer(id);
            ViewBag.getCompany = new SelectList(DataServices.Services.DealersService.Instance.listofCompanies(), "CompanyId", "CompanyName");
            return View(getDealerForEdit);
        }

        [HttpPost]
        public ActionResult Edit(tblDealer dealer,int id)
        {
            DataServices.Services.DealersService.Instance.UpdateDealer(dealer,id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult delete(int id)
        {
            DataServices.Services.DealersService.Instance.DeleteDealer(id);
            return RedirectToAction("index");
        }
    }
}
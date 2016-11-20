using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;
using System.Web.Security;
using medicalsystem.Models;
namespace medicalsystem.Controllers
{
    [Authorize(Roles = "A")]
    public class CompanyController : Controller
    {
        // GET: Company
        
        public ActionResult Index()
        {
            CompanyModel model = new CompanyModel();
            model.CompanyDetails = DataServices.Services.CompanyService.Instance.Companies();
            //var result = DataServices.Services.CompanyService.Instance.Companies();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblCompay company)
        {
            DataServices.Services.CompanyService.Instance.AddCompany(company);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var getCompanyForEdit = DataServices.Services.CompanyService.Instance.EditCompany(id);
            return View(getCompanyForEdit);
        }

        [HttpPost]
        public ActionResult Edit(tblCompay  comp, int id)
        {
            DataServices.Services.CompanyService.Instance.UpdateCompany(comp,id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DataServices.Services.CompanyService.Instance.DeleteCompany(id);
            return RedirectToAction("Index");
        }

    }
}
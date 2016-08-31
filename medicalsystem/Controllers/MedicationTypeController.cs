using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using constrng;

namespace medicalsystem.Controllers
{
    public class MedicationTypeController : Controller
    {
        // GET: Type
        public ActionResult Index()
        {
            return View(DataServices.Services.MedicationTypeService.Instance.MedicationTypes());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tblType Type)
        {
            DataServices.Services.MedicationTypeService.Instance.AddMedicationType(Type);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(DataServices.Services.MedicationTypeService.Instance.EditMedicationType(id));
        }

        [HttpPost]
        public ActionResult Edit(tblType type)
        {
            DataServices.Services.MedicationTypeService.Instance.UpdateMedicationType(type);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            DataServices.Services.MedicationTypeService.Instance.DeleteMedicationType(id);
            return RedirectToAction("Index");
        }
    }
}
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
        public ActionResult Create(ProductRecieved prorec, string Date,int[] Prid,int[] Qty,int[] Cost,int[] Price,string[] Mfg,string[] Exp,string[] Batch)
        {
            tblProductReceivedMaster prMaster = new tblProductReceivedMaster();
            prMaster.DealerId = prorec.ModelMaster.DealerId;
            prMaster.Date =Convert.ToDateTime(Date);
            prMaster.Amount = prorec.ModelMaster.Amount;
            prMaster.Remarks = prorec.ModelMaster.Remarks;
            int MrId = DataServices.Services.RecievedProduct.Instance.InsertMasterRecieved(prMaster);
            if (MrId != 0)
            {
                tblProductReceivedDetail prdetail = new tblProductReceivedDetail();
                for(int i=0;i<Prid.Length;i++)
                {
                    prdetail.PRMId = MrId;
                    prdetail.ProductId = Prid[i];
                    prdetail.Quantity = Qty[i];
                    prdetail.PurchasingPrice = Cost[i];
                    prdetail.SellingPrice = Price[i];
                    prdetail.MfgDate = Convert.ToDateTime(Mfg[i]);
                    prdetail.ExpDate = Convert.ToDateTime(Exp[i]);
                    prdetail.BatchNo = Batch[i];
                    DataServices.Services.RecievedProduct.Instance.InsertDetailRecieved(prdetail);
                }
                // Detail Items Goes here.
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        // Get Detail Of Master Recieved.
        public ActionResult Edit(int id)
        {
            var MasterModel= DataServices.Services.RecievedProduct.Instance.EditMasterRecieved(id);
            ViewBag.getDealers = new SelectList(DataServices.Services.RecievedProduct.Instance.listofDealers(), "DealId", "DealerName");
            return View(MasterModel);
        }

    }
}
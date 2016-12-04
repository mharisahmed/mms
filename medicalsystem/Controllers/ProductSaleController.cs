using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using medicalsystem.Models;
using constrng;

namespace medicalsystem.Controllers
{
    public class ProductSaleController : Controller
    {
        // GET: ProductSale
        public ActionResult Index()
        {
            ProductSale model = new ProductSale();
            model.SaleMaster = DataServices.Services.SaleProduct.Instance.SaleMasterDetails().ToList() ;
            return View(model);
        }
        public ActionResult Details(int id)
        {
            ProductSale model = new ProductSale();
            model.SaleDetails = DataServices.Services.SaleProduct.Instance.SaleDetailDetails(id).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.getProduct = new SelectList(DataServices.Services.RecievedProduct.Instance.listofProduct(), "ProductId", "ProductName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(ProductSale salepro, string Date, int[] Prid, int[] Qty, int[] Price)
        {
            tblSaleMaster psMaster = new tblSaleMaster();
            psMaster.CustomerName = salepro.SaleMastert.CustomerName;
            psMaster.Date = Convert.ToDateTime(Date);
            psMaster.Amount = salepro.SaleMastert.Amount;
            psMaster.Remarks = salepro.SaleMastert.Remarks;
            psMaster.Discount = salepro.SaleMastert.Discount;
            int MrId = DataServices.Services.SaleProduct.Instance.InsertMasterRecieved(psMaster);
            if (MrId != 0)
            {
                tblSaleDetail prdetail = new tblSaleDetail();
                for (int i = 0; i < Prid.Length; i++)
                {
                    prdetail.SMId = MrId;
                    prdetail.ProductId = Prid[i];
                    prdetail.Quantity = Qty[i];
                    prdetail.Rate = Price[i];
                    DataServices.Services.SaleProduct.Instance.InsertDetailRecieved(prdetail);
                }
                // Detail Items Goes here.
            }
            return RedirectToAction("Index");
        }
    }
}
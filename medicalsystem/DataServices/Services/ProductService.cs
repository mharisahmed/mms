using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;


namespace medicalsystem.DataServices.Services
{
    public class ProductService
    {
        private static ProductService _service = null;

        public static ProductService Instance => _service ?? (_service = new ProductService());

        public List<tblProduct> getproducts()
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var sql = 
                          " select p.*,t.TypeName as TypeName from tblProduct p " +
                          "inner join tblType t on p.TypeId = t.TypeId";
                var abc = _context.Fetch<tblProduct>(sql);
                return abc;
            }           
        }

        public List<tblType> listoftypes() {
            using (var _context = DataContextHelper.GetContext())
            {
                return _context.Fetch<tblType>("Select * from tblType");
            }
        }


        //Add New product
        public void AddProduct(tblProduct product)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Insert(product);

            }
        }

        //Get Recode for Update
        public tblCompay EditCompany(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var Company = _context.Single<tblCompay>("Select * From tblCompay where CompanyId=@0", id);
                return Company;
            }
        }

        // Update Record.
        public void UpdateCompany(tblCompay comp)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(comp);
            }

        }

        // Delete Record.
        public void DeleteCompany(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Delete<tblCompay>(id);
            }

        }

    }
}
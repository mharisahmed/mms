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
        public tblProduct EditProduct(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                var Product = _context.Single<tblProduct>("Select * From tblProduct where ProductId=@0", id);
                return Product;
            }
        }

        // Update Record.
        public void UpdateProduct(tblProduct prod, int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(prod,id);
            }

        }

        // Delete Record.
        public void DeleteProduct(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Delete<tblProduct>(id);
            }

        }

    }
}
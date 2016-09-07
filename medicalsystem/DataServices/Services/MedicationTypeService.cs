using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using constrng;
namespace medicalsystem.DataServices.Services
{
    public class MedicationTypeService
    {
        private static MedicationTypeService _service = null;

        public static MedicationTypeService Instance => _service ?? (_service = new MedicationTypeService());

        public List<tblType> MedicationTypes()
        {

            using (var _context = DataContextHelper.GetContext())
            {
                var result = _context.Fetch<tblType>("select * from tblType");

                return result;

            }

        }

        //Add New Type
        public void AddMedicationType(tblType Type)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Insert(Type);

            }
        }

        //Get Recode for Update
        public tblType EditMedicationType(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                return  _context.Single<tblType>("Select * From tblType where TypeId=@0", id);         
            }
        }

        // Update Record.
        public void UpdateMedicationType(tblType type,int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Update(type,id);
            }

        }

        // Delete Record.
        public void DeleteMedicationType(int id)
        {
            using (var _context = DataContextHelper.GetContext())
            {
                _context.Delete<tblType>(id);
            }

        }

    }
}
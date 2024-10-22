using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class SupplierBL
    {
        private static SupplierBL _instance;
        public static SupplierBL Instance
        {
            get
            {
                return _instance ?? (_instance = new SupplierBL());

            }
        }

        public bool Insert(Supplier entity)
        {
            bool result = false;
            try
            {
                result = SupplierDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Supplier entity)
        {
            bool result = false;
            try
            {
                result = SupplierDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                result = SupplierDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Supplier> SelectAll()
        {
            List<Supplier> result = null;
            try
            {
                result = SupplierDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Supplier SelectById(int id)
        {
            Supplier result = null;
            try
            {
                result = SupplierDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
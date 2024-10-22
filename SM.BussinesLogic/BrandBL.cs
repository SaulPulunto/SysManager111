using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class BrandBL
    {
        private static BrandBL _instance;
        public static BrandBL Instance
        {
            get
            {
                return _instance ?? (_instance = new BrandBL());

            }
        }

        public bool Insert(Brand entity)
        {
            bool result = false;
            try
            {
                result = BrandDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Brand entity)
        {
            bool result = false;
            try
            {
                result = BrandDAL.Instance.Update(entity);
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
                result = BrandDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Brand> SelectAll()
        {
            List<Brand> result = null;
            try
            {
                result = BrandDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Brand SelectById(int id)
        {
            Brand result = null;
            try
            {
                result = BrandDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
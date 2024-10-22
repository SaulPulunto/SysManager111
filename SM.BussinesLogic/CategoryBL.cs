using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;
using System.Data.SqlClient;

namespace SM.BussinesLogic
{
    public class CategoryBL
    {
        private static CategoryBL _instance;
        public static CategoryBL Instance
        {
            get
            {
                return _instance ?? (_instance = new CategoryBL());

            }
        }

        public bool Insert(Category entity)
        {
            bool result = false;
            try
            {
                result = CategoryDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }


        public bool Update(Category entity)
        {
            bool result = false;
            try
            {
                result = CategoryDAL.Instance.Update(entity);
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
                result = CategoryDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Category> SelectAll()
        {
            List<Category> result = null;
            try
            {
                result = CategoryDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Category SelectById(int id)
        {
            Category result = null;
            try
            {
                result = CategoryDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
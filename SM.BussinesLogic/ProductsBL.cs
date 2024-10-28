using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class ProductsBL
    {
        private static ProductsBL _instance;
        public static ProductsBL Instance
        {
            get
            {
                return _instance ?? (_instance = new ProductsBL());

            }
        }

        public bool Insert(Products entity)
        {
            bool result = false;
            try
            {
                result = ProductsDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Update(Products entity)
        {
            bool result = false;
            try
            {
                result = ProductsDAL.Instance.Update(entity);
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
                result = ProductsDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Products> SelectAll()
        {
            List<Products> result = null;
            try
            {
                result = ProductsDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
        private readonly ProductsDAL usersDAL_;

        public Products SelectById(int id)
        {
            Products result = null;
            try
            {
                result = ProductsDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}

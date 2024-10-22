using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class ProductTypeBL
    {
        private static ProductTypeBL _instance;
        public static ProductTypeBL Instance
        {
            get
            {
                return _instance ?? (_instance = new ProductTypeBL());

            }
        }

        public bool Insert(ProductType entity)
        {
            bool result = false;
            try
            {
                result = ProductTypeDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(ProductType entity)
        {
            bool result = false;
            try
            {
                result = ProductTypeDAL.Instance.Update(entity);
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
                result = ProductTypeDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<ProductType> SelectAll()
        {
            List<ProductType> result = null;
            try
            {
                result = ProductTypeDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public ProductType SelectById(int id)
        {
            ProductType result = null;
            try
            {
                result = ProductTypeDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
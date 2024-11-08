using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class StockBL
    {
        private static StockBL _instance;
        public static StockBL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockBL());

            }
        }

        public bool Insert(Stock entity)
        {
            bool result = false;
            try
            {
                result = StockDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Update(Stock entity)
        {
            bool result = false;
            try
            {
                result = StockDAL.Instance.Update(entity);
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
                result = StockDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Stock> SelectAll()
        {
            List<Stock> result = null;
            try
            {
                result = StockDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
        private readonly ProductsDAL usersDAL_;

        public Stock SelectById(int id)
        {
            Stock result = null;
            try
            {
                result = StockDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}

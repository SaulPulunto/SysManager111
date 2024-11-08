using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class CustomerBL
    {
        private static CustomerBL _instance;
        public static CustomerBL Instance
        {
            get
            {
                return _instance ?? (_instance = new CustomerBL());

            }
        }

        public bool Insert(Customer entity)
        {
            bool result = false;
            try
            {
                result = CustomerDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Customer entity)
        {
            bool result = false;
            try
            {
                result = CustomerDAL.Instance.Update(entity);
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
                result = CustomerDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Customer> SelectAll()
        {
            List<Customer> result = null;
            try
            {
                result = CustomerDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Customer SelectById(int id)
        {
            Customer result = null;
            try
            {
                result = CustomerBL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
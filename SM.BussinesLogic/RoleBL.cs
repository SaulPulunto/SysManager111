using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class RoleBL
    {
        private static RoleBL _instance;
        public static RoleBL Instance
        {
            get
            {
                return _instance ?? (_instance = new RoleBL());

            }
        }

        public bool Insert(Role entity)
        {
            bool result = false;
            try
            {
                result = RoleDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Update(Role entity)
        {
            bool result = false;
            try
            {
                result = RoleDAL.Instance.Update(entity);
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
                result = RoleDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Role> SelectAll()
        {
            List<Role> result = null;
            try
            {
                result = RoleDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Role SelectById(int id)
        {
            Role result = null;
            try
            {
                result = RoleDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}
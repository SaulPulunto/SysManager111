using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;
using SM.DataAccess;

namespace SM.BussinessLogic
{
    public class UsersBL
    {
        private static UsersBL _instance;
        public static UsersBL Instance
        {
            get
            {
                return _instance ?? (_instance = new UsersBL());

            }
        }

        public bool Insert(Users entity)
        {
            bool result = false;
            try
            {
                result = UsersDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }



        public bool Update(Users entity)
        {
            bool result = false;
            try
            {
                result = UsersDAL.Instance.Update(entity);
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
                result = UsersDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Users> SelectAll()
        {
            List<Users> result = null;
            try
            {
                result = UsersDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
        private readonly UsersDAL usersDAL_;

        public Users SelectById(int id)
        {
            Users result = null;
            try
            {
                result = UsersDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
        public bool Login(string email, string password)
        {
            try
            {
                return UsersDAL.Instance.VerificarUsuario(email, password);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el usuario", ex);
            }
        }

    }
}

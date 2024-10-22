using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SM.Entity;

namespace SM.DataAccess
{
    public class RoleDAL : Connection
    {
        private static RoleDAL _instance;
        public static RoleDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new RoleDAL());
            }
        }
        public bool Insert(Role entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spRoleInsert", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@role", entity.role);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Role entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spRoleUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@roleID", entity.roleID);
                    cmd.Parameters.AddWithValue("@role", entity.role);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("SpRoleDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@roleID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Role> SelectAll()
        {
            List<Role> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spRoleSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Role>();
                            while (dr.Read())
                            {
                                Role entity = new Role()
                                {
                                    roleID = dr.GetInt32(0),
                                    role = dr.GetString(1),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Role SelectById(int id)
        {
            Role result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spRoleSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@roleID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Role()
                                {
                                    roleID = dr.GetInt32(0),
                                    role = dr.GetString(1),
                                };
                            }
                        }
                    }
                }
            }
            return result;
        }

    }
}

using SM.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DataAccess
{
    public class UsersDAL : Connection
    {
        private static UsersDAL _instance;
        public static UsersDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new UsersDAL());
            }
        }
        public bool Insert(Users entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_strConn))
                {
                    using (SqlCommand cmd = new SqlCommand("spUsersInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@name", entity.name);
                        cmd.Parameters.AddWithValue("@LastName", entity.LastName);
                        cmd.Parameters.AddWithValue("@Email", entity.Email);
                        cmd.Parameters.AddWithValue("@Password", entity.password);
                        cmd.Parameters.AddWithValue("@address", entity.address);
                        cmd.Parameters.AddWithValue("@phone", entity.phone);
                        cmd.Parameters.AddWithValue("@roleID", entity.roleID);
                        cmd.Parameters.AddWithValue("@municipalityID", entity.municipalityID);
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el usuario: " + ex.Message);
                throw new Exception("Error al insertar el usuario: " + ex.Message);
            }
            return result;
        }

        


        public bool Update(Users entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spUsersUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usersID", entity.usersID);
                    cmd.Parameters.AddWithValue("@roleID", entity.roleID);
                    cmd.Parameters.AddWithValue("@municipalityID", entity.municipalityID);
                    cmd.Parameters.AddWithValue("@name", entity.name);
                    cmd.Parameters.AddWithValue("@LastName", entity.LastName);
                    cmd.Parameters.AddWithValue("@Email", entity.Email);
                    cmd.Parameters.AddWithValue("@Password", entity.password);
                    cmd.Parameters.AddWithValue("@address", entity.address);
                    cmd.Parameters.AddWithValue("@phone", entity.phone);
                    conn.Open();
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
                using (SqlCommand cmd = new SqlCommand("spUsersDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usersID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Users> SelectAll()
        {
            List<Users> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spUsersSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Users>();
                            while (dr.Read())
                            {
                                Users entity = new Users()
                                {
                                    usersID = dr.GetInt32(0),
                                    roleID = dr.GetInt32(1),
                                    municipalityID = dr.GetInt32(2),
                                    name = dr.GetString(3),
                                    LastName = dr.GetString(4),
                                    Email = dr.GetString(5),
                                    password = dr.GetString(6),
                                    address = dr.GetString(7),
                                    phone = dr.GetString(8),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Users SelectById(int id)
        {
            Users result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spUsersSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usersID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Users()
                                {
                                    usersID = dr.GetInt32(0),
                                    Email = dr.GetString(1),
                                };
                            }
                        }
                    }
                }
            }
            return result;
        }
        public bool VerificarUsuario(string email, string password)
        {
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spUsersValidate2", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    conn.Open();
                    int result = (int)cmd.ExecuteScalar();
                    return result > 0;
                }
            }
        }

    }
}

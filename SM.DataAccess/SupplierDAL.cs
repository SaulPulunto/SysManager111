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
    public class SupplierDAL : Connection
    {
        private static SupplierDAL _instance;
        public static SupplierDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new SupplierDAL());
            }
        }
        public bool Insert(Supplier entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierInsert", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", entity.name);
                    cmd.Parameters.AddWithValue("@phone", entity.phone);
                    cmd.Parameters.AddWithValue("@email", entity.email);
                    cmd.Parameters.AddWithValue("@address", entity.address);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Supplier entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@supplierID", entity.supplierID);
                    cmd.Parameters.AddWithValue("@name", entity.name);
                    cmd.Parameters.AddWithValue("@phone", entity.phone);
                    cmd.Parameters.AddWithValue("@email", entity.email);
                    cmd.Parameters.AddWithValue("@address", entity.address);
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
                using (SqlCommand cmd = new SqlCommand("spSupplierDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@supplierID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Supplier> SelectAll()
        {
            List<Supplier> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Supplier>();
                            while (dr.Read())
                            {
                                Supplier entity = new Supplier()
                                {
                                    supplierID = dr.GetInt32(0),
                                    name = dr.GetString(1),
                                    phone = dr.GetString(2),
                                    email = dr.GetString(3),
                                    address = dr.GetString(4),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Supplier SelectById(int id)
        {
            Supplier result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@supplierID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Supplier()
                                {
                                    supplierID = dr.GetInt32(0),
                                    name = dr.GetString(1),
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

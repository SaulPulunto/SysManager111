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
    public class CustomerDAL : Connection
    {
        private static CustomerDAL _instance;
        public static CustomerDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new CustomerDAL());
            }
        }
        public bool Insert(Customer entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spCustomerInsert", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", entity.name);
                    cmd.Parameters.AddWithValue("@lastname", entity.lastname);
                    cmd.Parameters.AddWithValue("@phone", entity.phone);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Customer entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spCustomerUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", entity.customerID);
                    cmd.Parameters.AddWithValue("@name", entity.name);
                    cmd.Parameters.AddWithValue("@lastname", entity.lastname);
                    cmd.Parameters.AddWithValue("@phone", entity.phone);
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
                using (SqlCommand cmd = new SqlCommand("SpCustomerDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Customer> SelectAll()
        {
            List<Customer> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spCustomerSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Customer>();
                            while (dr.Read())
                            {
                                Customer entity = new Customer()
                                {
                                    customerID = dr.GetInt32(0),
                                    name = dr.GetString(1),
                                    lastname = dr.GetString(2),
                                    phone = dr.GetString(3),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Customer SelectById(int id)
        {
            Customer result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spCustomerSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@customerID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Customer()
                                {
                                    customerID = dr.GetInt32(0),
                                    name = dr.GetString(1),
                                    lastname = dr.GetString(2),
                                    phone = dr.GetString(3),
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

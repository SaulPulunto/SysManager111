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
    public class BrandDAL : Connection
    {
        private static BrandDAL _instance;
        public static BrandDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new BrandDAL());
            }
        }
        public bool Insert(Brand entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spBrandInsert", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brandName", entity.brandName);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update( Brand entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spBrandUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brandID", entity.brandID);
                    cmd.Parameters.AddWithValue("@brandName", entity.brandName);
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
                using (SqlCommand cmd = new SqlCommand("spBrandDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productTypeID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Brand> SelectAll()
        {
            List<Brand> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spBrandSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Brand>();
                            while (dr.Read())
                            {
                                Brand entity = new Brand()
                                {
                                    brandID = dr.GetInt32(0),
                                    brandName = dr.GetString(1),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Brand SelectById(int id)
        {
            Brand result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spBrandSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@brandID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Brand()
                                {
                                    brandID = dr.GetInt32(0),
                                    brandName = dr.GetString(1),
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

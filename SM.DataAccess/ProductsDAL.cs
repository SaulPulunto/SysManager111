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
    public class ProductsDAL : Connection
    {
        private static ProductsDAL _instance;
        public static ProductsDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new ProductsDAL());
            }
        }
        public bool Insert(Products entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_strConn))
                {
                    using (SqlCommand cmd = new SqlCommand("spProductsInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@categoryID", entity.categoryID);
                        cmd.Parameters.AddWithValue("@brandID", entity.brandID);
                        cmd.Parameters.AddWithValue("@productTypeID", entity.productTypeID);
                        cmd.Parameters.AddWithValue("@productName", entity.productName);
                        cmd.Parameters.AddWithValue("@description", entity.description);
                        cmd.Parameters.AddWithValue("@price", entity.price);
                        conn.Open();
                        result = cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el Producto: " + ex.Message);
                throw new Exception("Error al insertar el Producto: " + ex.Message);
            }
            return result;
        }




        public bool Update(Products entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spProductsUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productsID", entity.productsID);
                    cmd.Parameters.AddWithValue("@categoryID", entity.categoryID);
                    cmd.Parameters.AddWithValue("@brandID", entity.brandID);
                    cmd.Parameters.AddWithValue("@productTypeID", entity.productTypeID);
                    cmd.Parameters.AddWithValue("@productName", entity.productName);
                    cmd.Parameters.AddWithValue("@description", entity.description);
                    cmd.Parameters.AddWithValue("@price", entity.price);
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
                using (SqlCommand cmd = new SqlCommand("spProductsDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productsID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Products> SelectAll()
        {
            List<Products> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spProductsSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Products>();
                            while (dr.Read())
                            {
                                Products entity = new Products()
                                {
                                    productsID = dr.GetInt32(0),
                                    categoryID = dr.GetInt32(1),
                                    brandID = dr.GetInt32(2),
                                    productTypeID = dr.GetInt32(3),
                                    productName = dr.GetString(4),
                                    description = dr.GetString(5),
                                    price = dr.GetSqlMoney(6),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Products SelectById(int id)
        {
            Products result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spProductsSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@produtsID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Products()
                                {
                                    productsID = dr.GetInt32(0),
                                    productName = dr.GetString(1),
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

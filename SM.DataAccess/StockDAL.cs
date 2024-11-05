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
    public class StockDAL : Connection
    {
        private static StockDAL _instance;
        public static StockDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new StockDAL());
            }
        }
        public bool Insert(Stock entity)
        {
            bool result = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(_strConn))
                {
                    using (SqlCommand cmd = new SqlCommand("spStockInsert", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@stockstatusID", entity.stockstatusID);
                        cmd.Parameters.AddWithValue("@productsID", entity.productsID);
                        cmd.Parameters.AddWithValue("@branchID", entity.branchID);
                        cmd.Parameters.AddWithValue("@quantity", entity.quantity);
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




        public bool Update(Stock entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spStockUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stockID", entity.stockID);
                    cmd.Parameters.AddWithValue("@stockstatusID", entity.stockstatusID);
                    cmd.Parameters.AddWithValue("@productsID", entity.productsID);
                    cmd.Parameters.AddWithValue("@branchID", entity.branchID);
                    cmd.Parameters.AddWithValue("@quantity", entity.quantity);
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
                using (SqlCommand cmd = new SqlCommand("spStockDelete", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stockID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Stock> SelectAll()
        {
            List<Stock> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spStockSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Stock>();
                            while (dr.Read())
                            {
                                Stock entity = new Stock()
                                {
                                    stockID = dr.GetInt32(0),
                                    stockstatusID = dr.GetInt32(1),
                                    branchID = dr.GetInt32(2),
                                    productsID = dr.GetInt32(3),
                                    quantity = dr.GetInt32(4),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Stock SelectById(int id)
        {
            Stock result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spStockSelectByID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@stockID", id);
                    conn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                result = new Stock()
                                {
                                    stockID = dr.GetInt32(0),
                                    stockstatusID = dr.GetInt32(1),
                                    quantity = dr.GetInt32(2),
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

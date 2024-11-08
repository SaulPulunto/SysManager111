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
    public class PurchaseDAL:Connection
    {
        private static PurchaseDAL _instance;
        public static PurchaseDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new PurchaseDAL());
            }
        }
        public bool Insert(Purchase entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertPurchase", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@supplierID", entity.supplierID);
                    cmd.Parameters.AddWithValue("@productsID", entity.productsID);
                    cmd.Parameters.AddWithValue("@quantity", entity.quantity);
                    cmd.Parameters.AddWithValue("@totalpurchase", entity.totalpurchase);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public bool Update(Purchase entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSupplierUpdate", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@purchaseID", entity.purchaseID);
                    cmd.Parameters.AddWithValue("@resupplyID", entity.supplierID);
                    cmd.Parameters.AddWithValue("@productsID", entity.productsID);
                    cmd.Parameters.AddWithValue("@quantity", entity.quantity);
                    cmd.Parameters.AddWithValue("@totalpurchase", entity.totalpurchase);
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
                    cmd.Parameters.AddWithValue("@purchaseID", id);
                    conn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }

        public List<Purchase> SelectAll()
        {
            List<Purchase> result = null;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spPurchaseSelecta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            result = new List<Purchase>();
                            while (dr.Read())
                            {
                                Purchase entity = new Purchase()
                                {
                                    purchaseID = dr.GetInt32(0),
                                    productsID = dr.GetInt32(1),
                                    supplierID = dr.GetInt32(2),
                                    quantity = dr.GetInt32(3),
                                    totalpurchase = dr.GetDecimal(4),
                                };
                                result.Add(entity);
                            }
                        }
                    }
                }
            }
            return result;
        }

        public Purchase SelectById(int id)
        {
            Purchase result = null;
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
                                result = new Purchase()
                                {
                                    purchaseID = dr.GetInt32(0),
                                    productsID = dr.GetInt32(1),
                                    supplierID = dr.GetInt32(2),
                                    quantity = dr.GetInt32(3),
                                    totalpurchase = dr.GetDecimal(4),
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

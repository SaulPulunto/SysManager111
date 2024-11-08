using SM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SM.DataAccess
{
    public class SaleDAL : Connection
    {
        private static SaleDAL instance;
        public static SaleDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SaleDAL();
                return instance;
            }

        }

        public int Insert(Sale entity)
        {
            int result = 0;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSaleInsert", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SaleId", entity.SaleId);
                    cmd.Parameters.AddWithValue("@Date", entity.Date);
                    cmd.Parameters.AddWithValue("@UserID", entity.usersID);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.CommandType = CommandType.StoredProcedure;
                    result = (int)cmd.ExecuteScalar();
                }
            }
            return result;
        }


        public bool Update(Sale entity)
        {
            bool result = false;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSaleUpdate", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SaleId", entity.SaleId);
                    cmd.Parameters.AddWithValue("@Date", entity.Date);
                    cmd.Parameters.AddWithValue("@UserID", entity.usersID);
                    cmd.Parameters.AddWithValue("@Total", entity.Total);
                    cmd.CommandType = CommandType.StoredProcedure;
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
                using (SqlCommand cmd = new SqlCommand("spSaleDelete", conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SaleId", id);
                    cmd.CommandType = CommandType.StoredProcedure;

                    result = cmd.ExecuteNonQuery() > 0;
                }
            }
            return result;
        }


        public List<Sale> SelectAll()
        {
            List<Sale> listado = new List<Sale>();

            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSaleSelectAll", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                Sale _entity = new Sale();
                                _entity.SaleId = dr.GetInt32(0);
                                _entity.Date = dr.GetDateTime(1);
                                _entity.usersID = dr.GetInt32(2);
                                _entity.Total = dr.GetDecimal(3);
                                listado.Add(_entity);
                            }
                        }
                    }
                }
            }
            return listado;
        }


        public Sale Select(int id)
        {
            Sale _entity = new Sale();

            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("spSaleSelect", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    cmd.Parameters.AddWithValue("@SaleId", id);

                    using (SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.SingleResult))
                    {
                        if (dr != null)
                        {
                            while (dr.Read())
                            {
                                _entity.SaleId = dr.GetInt32(0);
                                _entity.Date = dr.GetDateTime(1);
                                _entity.usersID = dr.GetInt32(2);
                                _entity.Total = dr.GetDecimal(3);
                            }
                        }
                    }
                }
                return _entity;
            }


        }
    }
}

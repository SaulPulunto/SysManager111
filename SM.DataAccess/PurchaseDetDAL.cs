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
    public class PurchaseDetDAL:Connection
    {

        private static PurchaseDetDAL _instance;
        public static PurchaseDetDAL Instance
        {
            get
            {
                return _instance ?? (_instance = new PurchaseDetDAL());
            }
        }

        public int Insert(PurchaseDet purchase)
        {
            int purchaseDetID;
            using (SqlConnection conn = new SqlConnection(_strConn))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertPurchaseDetail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@Date", purchase.Date));
                    cmd.Parameters.Add(new SqlParameter("@Total", purchase.Total));

                    SqlParameter outputIdParam = new SqlParameter("@purchaseDetID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    purchaseDetID = (int)outputIdParam.Value;
                }
            }
            return purchaseDetID;
        }

        

    }
}

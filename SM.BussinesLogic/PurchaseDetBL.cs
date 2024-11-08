using SM.BussinessLogic;
using SM.DataAccess;
using SM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BussinesLogic
{
    public class PurchaseDetBL
    {
        private static PurchaseDetBL _instance;
        public static PurchaseDetBL Instance
        {
            get
            {
                return _instance ?? (_instance = new PurchaseDetBL());

            }
        }
        public int Insert(PurchaseDet purchase) 
        { try 
            { 
                return PurchaseDetDAL.Instance.Insert(purchase); 
            }
            catch 
            (Exception ex) 
            { throw new Exception(ex.Message); } }

    }
}

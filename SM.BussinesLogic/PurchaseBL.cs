using SM.DataAccess;
using SM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.BussinesLogic
{
    public class PurchaseBL
    {
        private static PurchaseBL _instance;
        public static PurchaseBL Instance
        {
            get
            {
                return _instance ?? (_instance = new PurchaseBL());

            }
        }

        public bool Insert(PurchaseDet purchaseDetail, List<Purchase> purchaseDetailsList)
        {
            bool result = false;

            try
            {
                // Insertar la compra principal
                int purchaseDetailID = PurchaseDetDAL.Instance.Insert(purchaseDetail);

                // Insertar los detalles de la compra utilizando el ID generado
                foreach (var detail in purchaseDetailsList)
                {
                    detail.purchaseID = purchaseDetailID;
                    PurchaseDAL.Instance.Insert(detail);
                }

                result = true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }


        public bool Insert(Purchase entity)
        {
            bool result = false;
            try
            {
                result = PurchaseDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }


        public bool Update(Purchase entity)
        {
            bool result = false;
            try
            {
                result = PurchaseDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                result = PurchaseDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;
        }

        public List<Purchase> SelectAll()
        {
            List<Purchase> result = null;
            try
            {
                result = PurchaseDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }

        public Purchase SelectById(int id)
        {
            Purchase result = null;
            try
            {
                result = PurchaseDAL.Instance.SelectById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return result;

        }
    }
}

using SM.Entity;
using SM.DataAccess;
using System;
using System.Collections.Generic;

namespace SM.BussinessLogic
{
    public class SaleBL
    {
        private static SaleBL instance;
        public static SaleBL Instance
        {
            get
            {
                if (instance == null)
                    instance = new SaleBL();
                return instance;
            }
        }

        public int Insert(Sale entity)
        {
            int result = 0;
            try
            {
                result = SaleDAL.Instance.Insert(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar la venta: " + ex.Message);
            }
            return result;
        }

        public bool Update(Sale entity)
        {
            bool result = false;
            try
            {
                result = SaleDAL.Instance.Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar la venta: " + ex.Message);
            }
            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            try
            {
                result = SaleDAL.Instance.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar la venta: " + ex.Message);
            }
            return result;
        }

        public List<Sale> SelectAll()
        {
            List<Sale> result = null;
            try
            {
                result = SaleDAL.Instance.SelectAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al seleccionar todas las ventas: " + ex.Message);
            }
            return result;
        }

        public Sale Select(int id)
        {
            Sale result = null;
            try
            {
                result = SaleDAL.Instance.Select(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al seleccionar la venta por ID: " + ex.Message);
            }
            return result;
        }
    }
}

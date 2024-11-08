using SM.DataAccess;
using SM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.View.Repo
{
    public class RepositorySup
    {
        private SupplierDAL dal = new SupplierDAL();

        public List<Supplier> GetSuppliers()
        {
            return dal.GetSu();
        }

        public List<Supplier> Select()
        {
            return dal.SelectAll();
        }

        private ProductsDAL _dal = new ProductsDAL();

        public List<Products> GetProducts()
        {
            return _dal.GetPro();
        }

        public List<Products> SelectAll()
        {
            return _dal.SelectAll();
        }



    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Invoice
    {
        public int invoiceID {  get; set; }
        public int categoryID { get; set; }
        public int brandID { get; set; }
        public int productTypeID { get; set; }
        public string productName { get; set; }
        public string description { get; set; }
        public SqlMoney price { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Sale
    {
        public int saleID { get; set; }
        public int invoiceID { get; set; }
        public int productsID { get; set; }
        public string quantity { get; set; }
        public SqlMoney price { get; set; }
    }
}

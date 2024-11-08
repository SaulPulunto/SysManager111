using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Purchase
    {
        public int purchaseID {  get; set; }
        public int purchaseDetID { get; set; }
        public int supplierID { get; set; }
        public int productsID { get; set; }
        public int quantity { get; set; }
        public decimal totalpurchase { get; set; }
    }
}

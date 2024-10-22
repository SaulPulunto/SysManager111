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
        public int resupplyID { get; set; }
        public int productsID { get; set; }
        public string quantity { get; set; }
        public string totalpurchase { get; set; }
    }
}

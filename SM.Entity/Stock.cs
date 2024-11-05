using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Stock
    {
        public int stockID {  get; set; }
        public int stockstatusID { get; set; }
        public int productsID { get; set; }
        public int branchID { get; set; }
        public int quantity { get; set; }
    }
}

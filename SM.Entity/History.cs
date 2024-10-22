using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class History
    {
        public int historyID { get; set; }
        public int productsID { get; set; }
        public int stockID { get; set; }
        public string quantity { get; set; }
    }
}

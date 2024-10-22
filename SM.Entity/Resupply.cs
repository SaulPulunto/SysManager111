using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Resupply
    {
        public int resupplyID {  get; set; }
        public int supplierID { get; set; }
        public int branchID { get; set; }
        public SqlMoney totalexpendidure { get; set; }
    }
}

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
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public int usersID { get; set; }
        public decimal Total { get; set; }
    }
}
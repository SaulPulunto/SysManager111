using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Branch
    {
        public int branchID {  get; set; }
        public int municipalityID { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    }
}

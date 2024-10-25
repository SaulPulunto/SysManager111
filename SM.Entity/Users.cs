using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.Entity
{
    public class Users
    {
        public int usersID { get; set; }
        public int roleID { get; set; }
        public int municipalityID { get; set; }
        public string name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
    }
}

using SM.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM.DataAccess
{
    public class Connection
    {
        protected string _strConn = ConfigurationManager
            .ConnectionStrings["conn"].ConnectionString;
    }
}
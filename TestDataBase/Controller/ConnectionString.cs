using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TestDataBase.Controller
{
    class ConnectionString
    {
        public static string connectionString
        {
            get 
            {
            return ConfigurationManager.ConnectionStrings["TestDataBase.Properties." +
                "Settings.CompanyDBConnectionString"].ConnectionString;
            }
        }
    }
}

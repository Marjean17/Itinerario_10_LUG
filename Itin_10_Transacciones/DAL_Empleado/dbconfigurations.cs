using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Empleado
{
    public static class dbconfigurations
    {
        private const string DB_CONFIG_NAME = "dbConnection";
        public static string GetDBconnStr()
        { return ConfigurationManager.ConnectionStrings[DB_CONFIG_NAME].ConnectionString;}
    }
}

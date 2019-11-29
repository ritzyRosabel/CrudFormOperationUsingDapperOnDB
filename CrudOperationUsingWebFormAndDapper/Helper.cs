using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperationUsingWebFormAndDapper
{
    class Helper
    {
        public static string Vcs(string name)
            {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
            }
    }
}

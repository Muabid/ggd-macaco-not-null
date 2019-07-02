using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Utils
{
    public class ConfigurationUtils
    {

        public static DateTime Today()
        {
            return DateTime.Parse(ConfigurationManager.AppSettings["DATE"]);
        }

    }
}

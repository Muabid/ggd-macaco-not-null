using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class Compania
    {
        SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["FRBACrucero"].ConnectionString
                );

        public int comp_id { get; set; }

        public string comp_nombre { get; set; }

    }
}

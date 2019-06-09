using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class TipoServicio
    {
        SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["FRBACrucero"].ConnectionString
                );
        public int tipo_servicio_id { get; set; }

        public string tipo_servicio_descripcion { get; set; }

        public decimal tipo_servicio_porc_recargo { get; set; }
    }
}

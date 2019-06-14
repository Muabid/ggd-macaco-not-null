using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    public class Compania
    {
        public int comp_id { get; set; }

        public string comp_nombre { get; set; }

        public Compania(int comp_id, string comp_nombre)
        {
            this.comp_id = comp_id;
            this.comp_nombre = comp_nombre;
        }

        public override String ToString()
        {
            return comp_nombre;
        }

    }
}

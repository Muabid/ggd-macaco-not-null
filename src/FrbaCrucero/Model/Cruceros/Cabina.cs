using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class Cabina
    {
        public int cabi_id { get; set; }

        public decimal cabi_nro { get; set; }

        public decimal cabi_piso { get; set; }

        public int cabi_tipo_servicio { get; set; }

        public int cabi_crucero { get; set; }

    }
}

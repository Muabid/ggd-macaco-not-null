using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class BajaCrucero
    {
        public int baja_id { get; set; }

        public int baja_cruc_id { get; set; }

        public DateTime baja_cruc_fecha_fuera_servicio { get; set; }

        public DateTime baja_cruc_fecha_reinicio_servicio { get; set; }

        public string baja_cruc_motivo { get; set; }

    }
}

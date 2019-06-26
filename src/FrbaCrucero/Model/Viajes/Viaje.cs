using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Viajes
{
    public class Viaje
    {
        public int id { get; set; }
        public DateTime fecha_salida{ get; set; }
        public DateTime fecha_llegada { get; set; }
        public DateTime fecha_llegada_estimada { get; set; }
        public int crucero_id { get; set; }

        public Viaje(int id, DateTime fechaSalida, DateTime fechaLlegada, DateTime fechaLlegadaEstimada, int cruceroId)
        {
            this.id = id;
            this.fecha_salida = fechaSalida;
            this.fecha_llegada = fechaLlegada;
            this.fecha_llegada_estimada = fechaLlegadaEstimada;
            this.crucero_id = cruceroId;
        }
    }
}

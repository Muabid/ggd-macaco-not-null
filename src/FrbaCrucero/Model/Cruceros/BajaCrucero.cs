using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class BajaCrucero
    {

        // ESTAS SON LAS PROPIEDADES DE LA CLASE

        public int baja_id { get; set; }

        public int baja_cruc_id { get; set; }

        public DateTime baja_cruc_fecha_fuera_servicio { get; set; }

        public DateTime baja_cruc_fecha_reinicio_servicio { get; set; }

        public DateTime baja_cruc_fecha_definitiva { get; set; }

        public string baja_cruc_motivo { get; set; }

        // CONSTRUCTOR SIN PARAMETROS

        public BajaCrucero()
        {

        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR PARA REGISTRAR

        public BajaCrucero(int _baja_cruc_id, DateTime _baja_cruc_fecha_fuera_servicio,
            DateTime _baja_cruc_fecha_reinicio_servicio, string _baja_cruc_motivo)
        {
            this.baja_cruc_id = _baja_cruc_id;
            this.baja_cruc_fecha_fuera_servicio = _baja_cruc_fecha_fuera_servicio;
            this.baja_cruc_fecha_reinicio_servicio = _baja_cruc_fecha_reinicio_servicio;
            this.baja_cruc_motivo = _baja_cruc_motivo;
        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR PARA ACTUALIZAR

        public BajaCrucero(int _baja_cruc_id, DateTime _baja_cruc_fecha_fuera_servicio,
            DateTime _baja_cruc_fecha_reinicio_servicio, string _baja_cruc_motivo, int _baja_id)
        {
            this.baja_cruc_id = _baja_cruc_id;
            this.baja_cruc_fecha_fuera_servicio = _baja_cruc_fecha_fuera_servicio;
            this.baja_cruc_fecha_reinicio_servicio = _baja_cruc_fecha_reinicio_servicio;
            this.baja_cruc_motivo = _baja_cruc_motivo;
            this.baja_id = _baja_id;
        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR PARA ELIMINAR

        public BajaCrucero(int _baja_id)
        {
            this.baja_id = _baja_id;
        }

    }
}

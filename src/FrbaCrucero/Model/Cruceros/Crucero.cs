using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    public class Crucero
    {
        // ESTAS SON LAS PROPIEDADES DE LA CLASE

        public int cruc_id { get; set; }

        public int cruc_compañia_id { get; set; }

        public string cruc_nombre { get; set; }

        public int cruc_modelo { get; set; }

        public bool cruc_activo { get; set; }

        public DateTime cruc_fecha_alta { get; set; }

        public int cruc_cantidad_cabinas { get; set; }

        // CONSTRUCTOR SIN PARAMETROS

        public Crucero()
        {

        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA REGISTRAR

        public Crucero(int _cruc_compañia_id, string _cruc_nombre, int _cruc_modelo, bool _cruc_activo,
                DateTime _cruc_fecha_alta, int _cruc_cantidad_cabinas
               )
        {
            this.cruc_compañia_id = _cruc_compañia_id;

            this.cruc_nombre = _cruc_nombre;

            this.cruc_modelo = _cruc_modelo;

            this.cruc_activo = _cruc_activo;

            this.cruc_fecha_alta = _cruc_fecha_alta;

            this.cruc_cantidad_cabinas = _cruc_cantidad_cabinas;

        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA ACTUALIZAR

        public Crucero(int _cruc_compañia_id, string _cruc_nombre, int _cruc_modelo, bool _cruc_activo,
                DateTime _cruc_fecha_alta, int _cruc_cantidad_cabinas, int _cruc_id
               )
        {
            this.cruc_compañia_id = _cruc_compañia_id;

            this.cruc_nombre = _cruc_nombre;

            this.cruc_modelo = _cruc_modelo;

            this.cruc_activo = _cruc_activo;

            this.cruc_fecha_alta = _cruc_fecha_alta;

            this.cruc_cantidad_cabinas = _cruc_cantidad_cabinas;

            this.cruc_id = _cruc_id;

        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA ELIMINAR

        public Crucero(int _cruc_id)
        {
            this.cruc_id = _cruc_id;
        }

    }
}

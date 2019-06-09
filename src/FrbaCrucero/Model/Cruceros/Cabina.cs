using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class Cabina
    {
        SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["FRBACrucero"].ConnectionString
                );

        // ESTAS SON LAS PROPIEDADES DE LA CLASE

        public int cabi_id { get; set; }

        public decimal cabi_nro { get; set; }

        public decimal cabi_piso { get; set; }

        public int cabi_tipo_servicio { get; set; }

        public int cabi_crucero { get; set; }

        // CONSTRUCTOR SIN PARAMETROS

        public Cabina()
        {

        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA REGISTRAR

        public Cabina(decimal _cabi_nro, decimal _cabi_piso, int _cabi_tipo_servicio, int _cabi_crucero)
        {
            this.cabi_nro = _cabi_nro;
            this.cabi_piso = _cabi_piso;
            this.cabi_tipo_servicio = _cabi_tipo_servicio;
            this.cabi_crucero = _cabi_crucero;
        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA ACTUALIZAR

        public Cabina(decimal _cabi_nro, decimal _cabi_piso, int _cabi_tipo_servicio, int _cabi_crucero, 
                int _cabi_id)
        {
            this.cabi_nro = _cabi_nro;
            this.cabi_piso = _cabi_piso;
            this.cabi_tipo_servicio = _cabi_tipo_servicio;
            this.cabi_crucero = _cabi_crucero;
            this.cabi_id = _cabi_id;
        }

        // ESTO ES UN CONSTRUCTOR CON PARAMETROS
        // CONSTRUCTOR ES PARA ELIMINAR

        public Cabina(int _cabi_id)
        {
            this.cabi_id = _cabi_id;
        }
    }
}

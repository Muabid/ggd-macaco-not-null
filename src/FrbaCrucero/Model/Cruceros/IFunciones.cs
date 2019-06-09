using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    interface IFunciones
    {
        int Registrar();

        bool Actualizar();

        bool Eliminar();

        DataTable Listar();

        DataTable BuscarPorNombre( string nombre);

        DataTable BuscarPorModelo( string modelo);

        DataTable BuscarPorCompañia( int campania);

        DataTable BuscarPorFechaDeAlta( DateTime fecha);


    }
}

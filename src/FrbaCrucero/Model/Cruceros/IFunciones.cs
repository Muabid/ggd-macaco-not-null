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

        DataTable BuscarPorNombre();

        DataTable BuscarPorModelo();

        DataTable BuscarPorCompañia(int campania);

        DataTable BuscarPorPisos(int piso);

        DataTable BuscarPorFechaDeAlta(DateTime fecha);


    }
}

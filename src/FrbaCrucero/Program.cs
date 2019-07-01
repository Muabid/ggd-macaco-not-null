﻿using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PantallaPrincipal());
            //Application.Run(new Login.PantallaInicio());
            //Application.Run(new CompraReservaPasaje.ComprarOReservarPasaje());
            //Application.Run(new Login.pantallaInicio());
            //Application.Run(new CompraReservaPasaje.Cliente());
            //Application.Run(new AbmRecorrido.RecorridoAbm());
            //Application.Run(new AbmRol.RolAbm());
            Application.Run(new GeneracionViaje.GenerarViaje());
            //Application.Run(new PagoReserva.PagoReserva());
            //Application.Run(new ComprarOReservarPasaje());
            //Application.Run(new AbmCrucero.FormPantallaInicio());
            //Application.Run(new ListadoEstadistico.ListadoEstadisticoForm());

        }
    }
}

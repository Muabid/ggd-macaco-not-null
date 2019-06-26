using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.CompraReservaPasaje
{
    public class Cliente
    {
       public int dni {get; set;}
        public String nombreApellido{get; set;}
        public String direccion { get; set; }
        public int telefono { get; set; }
        public String mail { get; set; }
        public DateTime fechaNacimiento { get; set; }
      public Cliente(int dni, String nombreApellido, String direccion, int telefono, String mail, DateTime fechaNacimiento)
        {


            this.dni = dni;
            this.nombreApellido = nombreApellido;
            this.direccion = direccion;
            this.telefono = telefono;
            this.mail = mail;
            this.fechaNacimiento = fechaNacimiento;


        }


        
    }
}

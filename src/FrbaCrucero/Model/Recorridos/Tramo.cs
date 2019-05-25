using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Recorridos
{
   public class Tramo
    {
       
        public Decimal precio { get; set; }
        
        public Puerto ciudadOrigen { get; set; }
        public Puerto ciudadDestino { get; set; }

        public Tramo(Decimal precio, Puerto ciudadOrigen, Puerto ciudadDestino)
        {
            this.precio = precio;
            this.ciudadDestino = ciudadDestino;
            this.ciudadOrigen = ciudadOrigen;
        }

   }
}

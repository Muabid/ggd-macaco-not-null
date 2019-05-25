using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Recorridos
{
   public class Puerto
    {
        public String id { get; set; }
        public String nombre { get; set; }

        public Puerto(String id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}

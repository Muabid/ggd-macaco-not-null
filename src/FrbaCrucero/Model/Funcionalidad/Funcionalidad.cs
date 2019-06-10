using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Funcionalidad
{
   public class Funcionalidad
    {

       public int id { get; set; }
       public String nombre { get; set; }
        
        
        public String ToString(){

            return this.nombre;

        }
    }


}

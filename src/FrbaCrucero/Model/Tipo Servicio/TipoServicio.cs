using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.TipoServicio
{
   public class TipoServicio
    {
        public int id { get; set; }
        public String descripcion { get; set; }
        public Double recargo { get; set; }

        public TipoServicio(int id, String descripcion, Double recargo)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.recargo = recargo;
        }

        public override string ToString()
        {
            return descripcion;
        }
    }
}

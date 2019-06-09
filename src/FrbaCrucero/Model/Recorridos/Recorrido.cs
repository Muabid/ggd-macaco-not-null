using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Recorridos
{
    class Recorrido
    {
        public int id { get; set; }
        public Decimal codigo { get; set; }

        public Recorrido(int _id, Decimal _codigo)
        {
            id = _id;
            codigo = _codigo;
        }

        public override string ToString()
        {
            return codigo.ToString();
        }
    }
}

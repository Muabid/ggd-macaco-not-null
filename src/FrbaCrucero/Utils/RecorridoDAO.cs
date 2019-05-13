using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero.Utils
{
    class RecorridoDAO
    {

        public DataTable getRecorridos()
        {
            SqlCommand query = Database.createCommand("SELECT reco_codigo FROM MACACO_NOT_NULL.RECORRIDO");
            return Database.getData(query);
        }
    }
}

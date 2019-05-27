using FrbaCrucero.Model.Recorridos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Utils
{
    class PuertoDAO
    {
        public List<Puerto> getPuertos()
        {
           SqlCommand command= Database.createCommand("SELECT [puer_id]"
               +",[puer_nombre] FROM [GD1C2019].[MACACO_NOT_NULL].[PUERTO] ORDER BY [puer_nombre] ASC");
           DataTable table = Database.getData(command);

           return table.Rows.Cast<DataRow>().
               Select(row => new Puerto(row["puer_id"].ToString(), row["puer_nombre"].ToString())).ToList<Puerto>();

        }
    }
}

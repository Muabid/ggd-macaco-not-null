using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using FrbaCrucero.Model.Roles;
using FrbaCrucero.Model.Funcionalidad;
using System.Data;

namespace FrbaCrucero.Utils
{
   public class RolDAO
    {



       public List<Funcionalidad> getFuncionalidades()
       {
           SqlCommand command = FrbaCrucero.Utils.Database.createCommand("SELECT [func_id]" +
                ",[func_detalle] FROM [GD1C2019].[MACACO_NOT_NULL].[FUNCIONALIDAD] ORDER BY [func_detalle] ASC");
           DataTable table = Utils.Database.getData(command);

           return table.Rows.Cast<DataRow>().
               Select(row => new Funcionalidad(int.Parse(row["func_id"].ToString()), row["func_detalle"].ToString())).ToList<Funcionalidad>();
           return null;
       }

       public DataTable getFuncionalidades(Rol rol)
       {
           SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetFuncionalidades");
           cmd.Parameters.Add(rol.id);
           return Database.getDataProcedure(cmd);
       }

    }
}

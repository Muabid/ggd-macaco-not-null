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
           
       }

       public DataTable getFuncionalidades(Rol rol)
       {
           SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetFuncionalidades");
           cmd.Parameters.Add("@rol_id",SqlDbType.Int).Value = rol.id;
           return Database.getDataProcedure(cmd);
       }


       public DataTable getFuncionalidadesXRol(Rol rol)
       {
           SqlCommand cmd = Database.createCommand("SELECT rol_funcionalidad_id ,func_id, func_detalle "
           + "FROM [MACACO_NOT_NULL].RolesXFuncionalidades WHERE rol_id = @rol_id");
           cmd.Parameters.Add("@rol_id", SqlDbType.Int).Value = rol.id;
           return Database.getData(cmd);
       }

       public void updateRol(int id, String nombre, DataTable funcionalidades)
       {

           SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].UpdateRol");
           cmd.Parameters.Add("@rol_id", SqlDbType.Int).Value = id;
           cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
           cmd.Parameters.Add("@funcionalidades",SqlDbType.Structured).Value = funcionalidades;
           Database.executeProcedure(cmd);
       }

    }
}

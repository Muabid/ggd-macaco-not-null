using FrbaCrucero.Model.Recorridos;
using FrbaCrucero.Model.TipoServicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Utils
{
    class TipoServicioDAO
    {
        public List<TipoServicio> getTiposServicios()
        {
            SqlCommand command = Database.createCommand("SELECT [tipo_servicio_id]" +
              ",[tipo_servicio_descripcion]"+
              ",[tipo_servicio_porc_recargo]"+
              "FROM [GD1C2019].[MACACO_NOT_NULL].[TIPO_SERVICIO] ORDER BY tipo_servicio_descripcion ASC");      
           DataTable table = Database.getData(command);
           return table.Rows.Cast<DataRow>().
               Select(row => new TipoServicio(int.Parse(row["tipo_servicio_id"].ToString()), row["tipo_servicio_descripcion"].ToString(), Double.Parse(row["tipo_servicio_porc_recargo"].ToString()))).ToList<TipoServicio>();

        }

        public TipoServicio getTipoServicioByDescription(String name)
        {
            SqlCommand command = Database.createCommand("[MACACO_NOT_NULL].GetTipoServicioByDescription");
            command.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = name;
            DataTable table = Database.getDataProcedure(command);
            DataRow tipoServicio = table.Rows[0];
            int id = int.Parse(tipoServicio["tipo_servicio_id"].ToString());
            String descripcion = (String)tipoServicio["tipo_servicio_descripcion"];
            Double recargo = (Double)tipoServicio["tipo_servicio_porc_recargo"];
            return new TipoServicio(id, descripcion, recargo);
        }
    }
}

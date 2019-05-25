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
    public class RecorridoDAO
    {
      /*  public void insertRecorrido(Decimal codRecorrido, List<Tramo> tramos)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].InsertRecorrido");
            cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
            cmd.Parameters.AddWithValue("@tramos", tramos);
            Database.executeProcedure(cmd);

        }

        public void insertTramos(Decimal codRecorrido,List<Tramo> tramos)
        {
            foreach (Tramo tramo in tramos)
            {
                SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].InsertTramo");
                cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
                cmd.Parameters.Add("@tram_puerto_desde", SqlDbType.Int).Value = tramo.ciudadOrigen.id;
                cmd.Parameters.Add("@tram_puerto_hasta", SqlDbType.Int).Value = tramo.ciudadDestino.id;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = tramo.precio;
            }
        }
        */

        public void insertRecorrido(Decimal codRecorrido, DataTable tramos)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].InsertRecorrido");
            cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
            cmd.Parameters.AddWithValue("@tramos", tramos);
            Database.executeProcedure(cmd);
        }
    }
}

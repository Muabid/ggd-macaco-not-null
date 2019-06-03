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

        public DataTable getRecorridos(String codRecorrido, String ciudadOrigen, String ciudadDestino)
        {
            
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].getRecorridos");

            SqlParameter origen =  cmd.Parameters.Add("@ciudad_origen", SqlDbType.NVarChar);
            SqlParameter destino = cmd.Parameters.Add("@ciudad_destino", SqlDbType.NVarChar);
            SqlParameter codigo = cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal);

            if (!String.IsNullOrEmpty(codRecorrido))
                codigo.Value = Convert.ToDecimal(codRecorrido);
            else
                codigo.Value = DBNull.Value;

            if (!String.IsNullOrEmpty(ciudadOrigen))
               origen.Value = ciudadOrigen;
            else
               origen.Value = DBNull.Value;

            if (!String.IsNullOrEmpty(ciudadDestino))
                destino.Value = ciudadDestino;
            else
                destino.Value = DBNull.Value;
           
            return Database.getDataProcedure(cmd);
        }

        public DataTable getTramos(Decimal codRecorrido)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetTramos");
            cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
            return Database.getDataProcedure(cmd);
        }

        public void darDeBaja(Decimal codRecorrido)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].BajaRecorrido");
            cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
            Database.executeProcedure(cmd);
        }


        public void modificarRecorrido(Decimal codRecorrido, DataTable tramos)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].ModificarRecorrido");
            cmd.Parameters.Add("@reco_codigo", SqlDbType.Decimal).Value = codRecorrido;
            cmd.Parameters.AddWithValue("@tramos", tramos);
            Database.executeProcedure(cmd);
        }

        public decimal precioRecorrido(Decimal codRec)
        {
            SqlCommand cmd = Database.createCommand("SELECT SUM(t.tram_precio_base) as precio "
	                                                   + "FROM MACACO_NOT_NULL.RECORRIDO AS r "
	                                                   + "LEFT JOIN MACACO_NOT_NULL.TRAMO t "
	                                                   + "ON r.reco_id = t.tram_recorrido_id "
                                                       + "WHERE reco_codigo = @reco_cod");
            cmd.Parameters.Add("@reco_cod", SqlDbType.Decimal).Value = codRec;
            return Database.executeScalarDecimal(cmd);
        }
    }
}

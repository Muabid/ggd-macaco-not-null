using FrbaCrucero.Model.Cruceros;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Utils
{
    public class CruceroDAO
    {

        public DataTable getCruceros(string nombre, string modelo,string compania, int cabinas,
            DateTime fechaAlta, DateTime disponibilidadInicio, DateTime disponibilidadFin)
        {
            return null;
        }

        public List<Compania> getCompaniasObj()
        {
            SqlCommand cmd = Database.createCommand("SELECT [comp_id],[comp_nombre] FROM [MACACO_NOT_NULL].COMPANIA");
            DataTable companias = Database.getData(cmd);
            return companias.Rows.Cast<DataRow>().Select(row =>
            {
                int id = int.Parse(row[0].ToString());
                string desc = row[1].ToString();
                return new Compania(id, desc);
            }).ToList<Compania>();
        }

        public List<object> getCompanias()
        {
            SqlCommand cmd = Database.createCommand("SELECT [comp_nombre] FROM [MACACO_NOT_NULL].COMPANIA");
            DataTable companias = Database.getData(cmd);
            return Database.toList(companias);
        }

        public List<object> getModelos()
        {
            SqlCommand cmd2 = Database.createCommand("SELECT DISTINCT [cruc_modelo] FROM [MACACO_NOT_NULL].CRUCERO");
            DataTable modelos = Database.getData(cmd2);
            return Database.toList(modelos);

        }

        public List<object> getTipoServicios()
        {
            SqlCommand cmd2 = Database.createCommand("SELECT  [tipo_servicio_descripcion] FROM [MACACO_NOT_NULL].TIPO_SERVICIO");
            DataTable tiposServicios = Database.getData(cmd2);
            return Database.toList(tiposServicios);
        }

        public DataTable getCabinas(Crucero crucero)
        {
            SqlCommand cmd2 = Database.createCommand("[MACACO_NOT_NULL].GetCabinasXPisoYServicio");
            cmd2.Parameters.Add("@crucero_id", SqlDbType.Int).Value = crucero.cruc_id;
            return Database.getDataProcedure(cmd2);
                 
        }

        public void updateCrucero(int cruc_id, String nombre, String modelo, int compania_id)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].UpdateCrucero");
            cmd.Parameters.Add("@crucero_id", SqlDbType.Int).Value = cruc_id;
            cmd.Parameters.Add("@nombre", SqlDbType.NChar).Value = nombre;
            cmd.Parameters.Add("@modelo",SqlDbType.NChar).Value = modelo;
            cmd.Parameters.Add("@compania", SqlDbType.Int).Value = compania_id;
            Database.executeProcedure(cmd);           
        }


     

    }
}

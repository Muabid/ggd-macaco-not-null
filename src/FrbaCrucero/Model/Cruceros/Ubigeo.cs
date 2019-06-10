using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Model.Cruceros
{
    class Ubigeo
    {
        SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["FRBACrucero"].ConnectionString
                );

        public DataTable ListarModelos()
        {
            // INSTANCIANDO A LA CLASE DATATABLE
            var tabla = new DataTable();
            // DataTable tabla = new DataTable();

            try
            {
                // CREANDO UNA INSTANCIA DE LA CLASE 
                // SQLDATAADAPTER
                using (var adaptador = new SqlDataAdapter("SELECT DISTINCT cruc_modelo FROM [MACACO_NOT_NULL].CRUCERO",cn))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }

            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;
        }

        public DataTable ListarCompanias()
        {
            // INSTANCIANDO A LA CLASE DATATABLE
            var tabla = new DataTable();
            // DataTable tabla = new DataTable();

            try
            {
                // CREANDO UNA INSTANCIA DE LA CLASE 
                // SQLDATAADAPTER
                using (var adaptador = new SqlDataAdapter("SELECT DISTINCT comp_nombre FROM [MACACO_NOT_NULL].COMPANIA", cn))
                {
                    adaptador.SelectCommand.CommandType = CommandType.Text;
                    adaptador.Fill(tabla);
                }

            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return tabla;
            }
            return tabla;
        }

    }
}

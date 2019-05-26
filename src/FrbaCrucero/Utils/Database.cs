using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Utils
{
    class Database
    {
        private static String connectionStr = ConfigurationManager.ConnectionStrings["FRBACrucero"]
            .ConnectionString;
        private static SqlConnection connection = new SqlConnection(connectionStr);

        public static SqlConnection getConnection()
        {
            return connection;
        }

        public static SqlCommand createCommand(String query)
        {
            return new SqlCommand(query,connection);
        }

        public static int execute(SqlCommand command)
        {
            
            connection.Open();
            int res = 0;
            try
            {
                res = command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return res;
        }


        public static int executeScalar(SqlCommand command)
        {

            connection.Open();
            int res = 0;
            try
            {
                res= (int)command.ExecuteScalar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            return res;
        }


        public static int executeProcedure(SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            return execute(command);
        }

        public static DataTable getData(SqlCommand query)
        {
           DataTable data = new DataTable();
           
            try{
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                adapter.Fill(data);
            }
            catch(Exception exception){
                MessageBox.Show(exception.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data;
        }

        public static DataTable getDataProcedure(SqlCommand query)
        {
            query.CommandType = CommandType.StoredProcedure;
            return getData(query);
        }
        



    }
}

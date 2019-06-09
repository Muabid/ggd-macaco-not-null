using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormAlta : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // INSTANCIAR LA CLASE SQLCONNECTION
            SqlConnection cn = new SqlConnection(
                ConfigurationManager.ConnectionStrings["FRBACrucero"].ConnectionString
                );

            cn.Open();

            MessageBox.Show("Conexion Exitosa");

            cn.Close();


        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            // INSTANCIAR LA CLASE UBIGEO
            var ubigeo = new Model.Cruceros.Ubigeo();
            var tabla = ubigeo.ListarModelos();
            var tabla1 = ubigeo.ListarCompanias();

            if (tabla.Rows.Count > 0)
            {
                cbo_modelo.DataSource = tabla;
                cbo_modelo.DisplayMember = "cruc_modelo";
                cbo_modelo.ValueMember = "";
            }

            if (tabla1.Rows.Count > 0)
            {
                cbo_compania.DataSource = tabla1;
                cbo_compania.DisplayMember = "comp_nombre";
                cbo_modelo.ValueMember = "";
            }
        }
    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Model.Roles;
using FrbaCrucero.Model.Funcionalidad;

namespace FrbaCrucero.AbmRol
{
    public partial class Modificacion : Form
    {
        public Modificacion()
        {
            InitializeComponent();

          /*  var funcionalidades = null;
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                comboBoxFuncionalidades.Items.Add(funcionalidad);
            }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {


            String rol = Rol.Text;
            String funcionalidad = (String)comboBoxFuncionalidades.SelectedValue;
            String activo = (String)Activo.Checked.ToString();
            MessageBox.Show(activo);
            MessageBox.Show(funcionalidad);
            MessageBox.Show(rol);

            modificacionTable.DataSource = this.getRoles(rol, funcionalidad, activo);



 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Modificacion_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == modificacionTable.Columns["columnSelection"].Index)
                {
                    int id = int.Parse(modificacionTable["columnRol_Id", e.RowIndex].Value.ToString());
                    String nombre = modificacionTable["columnRol_Name", e.RowIndex].Value.ToString();
                    bool activo = (bool)modificacionTable["Rol_activo", e.RowIndex].Value;
                    Rol nuevoRol = new Rol(id,nombre);

                    FormularioModificacion fma = new FormularioModificacion(nuevoRol);
                    fma.Show();
                }
            }
        }

        public DataTable getRoles(String NombreRol, String Funcionalidad, String activo)
        {

            SqlCommand cmd = Utils.Database.createCommand("[MACACO_NOT_NULL].BuscarRol");

            SqlParameter a_rol = cmd.Parameters.Add("@nombre_rol", SqlDbType.NVarChar);
            SqlParameter a_destino = cmd.Parameters.Add("@activo", SqlDbType.Bit);
            SqlParameter a_funcionalidad = cmd.Parameters.Add("@nombre_funcionalidad", SqlDbType.NVarChar);

            if (!String.IsNullOrEmpty(NombreRol))
                a_rol.Value = NombreRol;
            else
                a_rol.Value = DBNull.Value;

            if (!String.IsNullOrEmpty(activo))
                a_destino.Value = Convert.ToBoolean(activo);
            else
                a_destino.Value = DBNull.Value;

            if (!String.IsNullOrEmpty(Funcionalidad))
                a_funcionalidad.Value = Funcionalidad;
            else
                a_funcionalidad.Value = DBNull.Value;

            return Utils.Database.getDataProcedure(cmd);
        }

      



    }
}

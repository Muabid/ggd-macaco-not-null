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
using FrbaCrucero.Utils;

namespace FrbaCrucero.AbmRol
{
    public partial class Modificacion : Form
    {
        private RolDAO rolDao = new RolDAO();
        public Modificacion()
        {
            InitializeComponent();
            Activo.Checked = true;
            var funcionalidades =rolDao.getFuncionalidades() ;
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                comboBoxFuncionalidades.Items.Add(funcionalidad);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {


            String rol = Rol.Text;
            Funcionalidad funcionalidad = (Funcionalidad)comboBoxFuncionalidades.SelectedItem;

            String funcionalidadaStr = funcionalidad != null ? funcionalidad.nombre : null;
            String activo = (String)Activo.Checked.ToString();

            modificacionTable.DataSource = this.getRoles(rol, funcionalidadaStr, activo);

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
            MessageBox.Show(Funcionalidad);
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

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            if (this.modificacionTable.Rows.Count > 0)
            {

                this.modificacionTable.Rows.Clear();
                this.modificacionTable.Refresh();
            }
            this.comboBoxFuncionalidades.SelectedIndex = -1;
            this.Activo.Checked = false;

        }

      



    }
}

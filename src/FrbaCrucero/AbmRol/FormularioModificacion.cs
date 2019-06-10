using FrbaCrucero.Model.Roles;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Model.Funcionalidad;

namespace FrbaCrucero.AbmRol
{
    public partial class FormularioModificacion : Form
    {
        Rol rol;
        RolDAO rolDao = new RolDAO();
        public FormularioModificacion(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            NombreTextBox.Text = rol.nombre;
            btn_activar.Visible = !rol.activo;
            table_funcionalidades.DataSource = rolDao.getFuncionalidades(rol);
            var funcionalidades = rolDao.getFuncionalidades();
            foreach (Funcionalidad funcionalidad in funcionalidades)
            {
                comboBoxFuncionalidades.Items.Add(funcionalidad);
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

            Funcionalidad funcionalidad = (Funcionalidad)comboBoxFuncionalidades.SelectedItem;
            String funcionalidadaStr = funcionalidad != null ? funcionalidad.nombre : null;
            if (funcionalidadaStr != null)
            {
                DataTable algo = table_funcionalidades.DataSource as DataTable;
                DataRow row = algo.NewRow();
                row["func_id"] = funcionalidad.id;
                row["func_detalle"] = funcionalidad.nombre;
                algo.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void table_funcionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == table_funcionalidades.Columns["Eliminar"].Index)
                {
                    table_funcionalidades.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = rol.nombre;
            table_funcionalidades.DataSource = rolDao.getFuncionalidades(rol);

        }

        private void btn_activar_Click(object sender, EventArgs e)
        {
            SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.AltaRol");
            procedure.Parameters.Add("@nombre_rol", SqlDbType.NVarChar).Value = NombreTextBox.Text;
            procedure.Parameters.Add("@activo", SqlDbType.Bit).Value = 1;
            Utils.Database.executeProcedure(procedure);

           
            MessageBox.Show("Se activo el rol");
        }
    }
}

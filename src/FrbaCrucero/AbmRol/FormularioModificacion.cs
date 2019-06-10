using FrbaCrucero.Model.Roles;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void table_funcionalidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

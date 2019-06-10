using FrbaCrucero.Model.Roles;
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
        public FormularioModificacion(Rol rol)
        {
            InitializeComponent();
            this.rol = rol;
            NombreTextBox.Text = rol.nombre;
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

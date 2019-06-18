using FrbaCrucero.Model.Cruceros;
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

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormListadoCruceros : Form
    {

        private Utils.CruceroDAO cruceroDao = new Utils.CruceroDAO();
        private Crucero crucero = new Crucero();

        public FormListadoCruceros()
        {
            InitializeComponent();
        }

        private void FormListadoCruceros_Load(object sender, EventArgs e)
        {
            var companias = cruceroDao.getCompanias().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = cruceroDao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);
        }

        public void ShowModificar(Form form)
        {
            dgv_cruceros.Columns["Editar"].Visible = true;
            this.ShowDialog(form);
        }

        public void ShowBaja(Form form)
        {
            dgv_cruceros.Columns["Baja"].Visible = true;
            this.ShowDialog(form);
        }

        private void dgv_cruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewCellCollection cell = dgv_cruceros.Rows[e.RowIndex].Cells;
            crucero.cruc_id = Convert.ToInt32(cell["Id"].Value);
            crucero.cruc_nombre = cell["Nombre"].Value.ToString();
            crucero.cruc_modelo = cell["Modelo"].Value.ToString();
            if(!String.IsNullOrEmpty(cell["Alta"].Value.ToString()))
                crucero.cruc_fecha_alta = DateTime.Parse(cell["Alta"].Value.ToString());

            crucero.cruc_cantidad_cabinas = Convert.ToInt32(cell["Cabinas"].Value);
            crucero.cruc_compañia_id = Convert.ToInt32(cell["CompaniaId"].Value);
            
            if (e.ColumnIndex == dgv_cruceros.Columns["Baja"].Index)
                new FormBaja().ShowDialog(this);

            if (e.ColumnIndex == dgv_cruceros.Columns["Editar"].Index)
                new FormModificacion(crucero).ShowDialog(this);
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetCruceros");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Database.orDbNull(txt_nombre.Text);
            cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_modelo.Text);
            cmd.Parameters.Add("@compania", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_compania.Text);
            cmd.Parameters.Add("@cabinas", SqlDbType.NVarChar).Value = Database.orDbNull(txt_cabinas.Text);
            cmd.Parameters.Add("@fecha_salida", SqlDbType.DateTime2).Value = DBNull.Value;
            cmd.Parameters.Add("@fecha_llegada", SqlDbType.DateTime2).Value = DBNull.Value;
            dgv_cruceros.DataSource = Database.getDataProcedure(cmd);
        }

        public void reloadCruceros()
        {
            this.btn_buscar_Click_1(null, null);
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void btn_limpiar_Click_1(object sender, EventArgs e)
        {
            this.Controls.Cast<Control>().ToList()
               .Where(c => c is GroupBox)
               .SelectMany(c => c.Controls.Cast<Control>().ToList())
               .ToList().ForEach(c =>
               {
                   if (c is ComboBox)
                       ((ComboBox)c).SelectedIndex = -1;
                   if (c is TextBox)
                       c.Text = null;
                   if (c is DataGridView)
                       ((DataGridView)c).Rows.Clear();
               });
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            crucero.cruc_fecha_alta = monthCalendar1.SelectionRange.Start;
            txt_fecha_alta.Text = crucero.cruc_fecha_alta.Value.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionCruceros : Form
    {

        private DateTime salida;
        private DateTime llegada;
        private CruceroDAO dao = new CruceroDAO();
        public SeleccionCruceros(DateTime salida, DateTime llegada)
        {
            InitializeComponent();
            this.salida = salida;
            this.llegada = llegada;
            txt_llegada.Text = llegada.ToString();
            txt_salida.Text = salida.ToString();
        }

        private void FormListadoCruceros_Load(object sender, EventArgs e)
        {
            var companias = dao.getCompanias().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = dao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetCruceros");          
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Database.orDbNull(txt_nombre.Text);
            cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_modelo.Text);
            cmd.Parameters.Add("@compania", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_compania.Text);
            cmd.Parameters.Add("@cabinas", SqlDbType.NVarChar).Value = Database.orDbNull(txt_cabinas.Text);
            cmd.Parameters.Add("@fecha_salida", SqlDbType.DateTime2).Value = Database.orDbNull(salida);
            cmd.Parameters.Add("@fecha_llegada", SqlDbType.DateTime2).Value = Database.orDbNull(llegada);
            dgv_cruceros.DataSource = Database.getDataProcedure(cmd);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_compania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cabinas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_cruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_cruceros.Columns["seleccionar"].Index)
                {
                    GenerarViaje parent = (GenerarViaje)this.Owner;
                    Crucero crucero = new Crucero();
                    crucero.cruc_id = int.Parse(dgv_cruceros["cruc_id", e.RowIndex].Value.ToString());
                    crucero.cruc_nombre = dgv_cruceros["cruc_nombre", e.RowIndex].Value.ToString();
                    parent.updateCrucero(crucero);
                    this.Close();
                }

            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.dgv_cruceros.DataSource;
            if (dt != null)
                dt.Clear();
            this.Controls.Cast<Control>().ToList()
                .Where(c => c is GroupBox)
                .SelectMany(c => c.Controls.Cast<Control>().ToList())
                .ToList().ForEach(c =>
                {
                    if (c is ComboBox)
                        ((ComboBox)c).SelectedIndex = -1;
                    if (c is TextBox)
                        c.Text = null;
                    if (c is MonthCalendar)
                        ((MonthCalendar)c).Visible = false;
                });
        }
        
    }
}

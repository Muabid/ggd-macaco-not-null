using FrbaCrucero.Model.Cruceros;
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

namespace FrbaCrucero.AbmCrucero
{
    public partial class FormModificacion : Form
    {

        
        private Crucero crucero;
        private CruceroDAO cruceroDao = new CruceroDAO();
        public FormModificacion(Crucero crucero)
        {
            InitializeComponent();
            this.crucero = crucero;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.dgv_cabinas.DataSource;
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
                 });
             /*
            txt_nombre.Clear();
            cbo_modelo.SelectedIndex = -1;
            cbo_compania.SelectedIndex = -1;
            txt_cabinas.Clear();
            txt_fecha_alta.Clear();
            cbo_tipo_servicio.SelectedIndex = -1;
            txt_cantidad.Clear();
            txt_piso.Clear();
            dgv_cabinas.Rows.Clear();
             */ 
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            crucero.cruc_fecha_alta = monthCalendar1.SelectionRange.Start;
            txt_fecha_alta.Text = crucero.cruc_fecha_alta.Value.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void FormModificacion_Load(object sender, EventArgs e)
        {
            var companias = cruceroDao.getCompaniasObj().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = cruceroDao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);

            txt_cabinas.Text = crucero.cruc_cantidad_cabinas.ToString();
            txt_fecha_alta.Text = crucero.cruc_fecha_alta.HasValue ? crucero.cruc_fecha_alta.Value.ToString() : null;
            txt_nombre.Text = crucero.cruc_nombre;
            cbo_modelo.SelectedItem = crucero.cruc_modelo;
            var compania = cbo_compania.Items.Cast<Compania>().Where(c => c.comp_id == crucero.cruc_compañia_id).First();
            cbo_compania.SelectedItem = compania;

            dgv_cabinas.DataSource = cruceroDao.getCabinas(crucero);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                cruceroDao.updateCrucero(crucero.cruc_id, txt_nombre.Text,cbo_modelo.Text, ((Compania)cbo_compania.SelectedItem).comp_id);
                MessageBox.Show("El crucero fue MODIFICADO satisfactoriamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void FormModificacion_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void FormModificacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((FormListadoCruceros)this.Owner).reloadCruceros();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}

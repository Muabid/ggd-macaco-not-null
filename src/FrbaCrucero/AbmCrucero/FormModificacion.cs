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
            //LIMPIAR PANTALLA
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

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
    }
}

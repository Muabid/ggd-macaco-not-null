using FrbaCrucero.Model.Cruceros;
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
    public partial class FormBaja : Form
    {
        BajaCrucero bajaCrucero = new BajaCrucero();
        public FormBaja()
        {
            InitializeComponent();
        }
        int btn;
        private void btn_limpiar_Click(object sender, EventArgs e)
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
                    if (c is CheckBox)
                        ((CheckBox)c).Checked = false;
                });
           /*
            txt_fecha_fuera_servicio.Clear();
            txt_fecha_reinicio_servicio.Clear();
            txt_fecha_baja_definitiva.Clear();
            chb_fuera_de_servicio.Checked = false;
            chb_vida_util.Checked = false;
            txt_motivo.Clear();
            */

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (btn == 1)
            {
                bajaCrucero.baja_cruc_fecha_fuera_servicio = monthCalendar1.SelectionRange.Start;
                txt_fecha_fuera_servicio.Text = bajaCrucero.baja_cruc_fecha_fuera_servicio.ToShortDateString();
                monthCalendar1.Visible = false;
                btn = 0;
            }
            else
            {
                if (btn == 2)
                {
                    bajaCrucero.baja_cruc_fecha_reinicio_servicio = monthCalendar1.SelectionRange.Start;
                    txt_fecha_reinicio_servicio.Text = bajaCrucero.baja_cruc_fecha_reinicio_servicio.ToShortDateString();
                    monthCalendar1.Visible = false;
                    btn = 0;
                }
                else
                {
                    bajaCrucero.baja_cruc_fecha_definitiva = monthCalendar1.SelectionRange.Start;
                    txt_fecha_baja_definitiva.Text = bajaCrucero.baja_cruc_fecha_definitiva.ToShortDateString();
                    monthCalendar1.Visible = false;
                    btn = 0;
                }
            }
           

        }
        
        private void btn_seleccionar_fecha_fuera_servicio_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            btn = 1;
        }

        private void btn_seleccionar_fecha_reinicio_servicio_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            btn = 2;
        }

        private void btn_seleccionar_fecha_baja_definitiva_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            btn = 3;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

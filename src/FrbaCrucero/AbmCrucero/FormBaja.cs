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
    public partial class FormBaja : Form
    {
        private Crucero crucero;
        BajaCrucero bajaCrucero = new BajaCrucero();
        public FormBaja(Crucero crucero)
        {
            InitializeComponent();
            estadoPasajes.Items.Add("Reemplazar crucero por otro");
            estadoPasajes.Items.Add("Cancelar todos los pasajes");
            this.crucero = crucero;
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
                    if (c is MonthCalendar)
                        ((MonthCalendar)c).Visible = false;
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

        private void estadoPasajes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (estadoPasajes.Text == "Reemplazar crucero por otro")
            {


   




            }
            else if (estadoPasajes.Text == "Cancelar todos los pasajes")
            {

                 SqlCommand cancelarTodosPasajes = Database.createCommand(" [MACACO_NOT_NULL].CancelarPasajes");
                 cancelarTodosPasajes.Parameters.Add("@idCrucero", SqlDbType.Int).Value = crucero.cruc_id;
                 Database.executeProcedure(cancelarTodosPasajes);


            }
            else
            {

                MessageBox.Show("No se eligio ninguna opcion para los pasajes");
            }


            if (chb_vida_util.Checked)
            {

                SqlCommand cmd1 = Database.createCommand("[MACACO_NOT_NULL].AgregarBajaCruceroDefinitivo");
                cmd1.Parameters.Add("@idCrucero", SqlDbType.Int).Value = crucero.cruc_id;
                cmd1.Parameters.Add("@baja_cruc_fecha_fuera_servicio_definitiva", SqlDbType.DateTime2).Value = txt_fecha_baja_definitiva.Text;
                Database.executeProcedure(cmd1);

                MessageBox.Show("El  crucero fue dado de baja definitivo");

            }
            else if (chb_vida_util.Checked)
            {

                SqlCommand cmd2 = Database.createCommand("[MACACO_NOT_NULL].AgregarBajaCrucero");
                cmd2.Parameters.Add("@idCrucero", SqlDbType.Int).Value = crucero.cruc_id;
                cmd2.Parameters.Add("@baja_cruc_fecha_fuera_servicio", SqlDbType.DateTime2).Value = txt_fecha_fuera_servicio.Text;
                cmd2.Parameters.Add("@baja_cruc_fecha_reinicio_servicio", SqlDbType.DateTime2).Value = txt_fecha_reinicio_servicio.Text;
                cmd2.Parameters.Add("@motivo", SqlDbType.NVarChar).Value = txt_motivo.Text;

                
                Database.executeProcedure(cmd2);

                MessageBox.Show("El  crucero fue dado de baja temporal");

            }else{


                MessageBox.Show("No se eligio ninguna opcion, elegir definitivo o temporal");


            }




        }

        private void chb_fuera_de_servicio_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_vida_util.Checked == true)
            {
                chb_vida_util.Checked = false;

            }
        }

        private void chb_vida_util_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_fuera_de_servicio.Checked == true)
            {
                chb_fuera_de_servicio.Checked = false;
   
        }
                
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

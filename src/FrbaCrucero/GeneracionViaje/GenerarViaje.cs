using FrbaCrucero.AbmCrucero;
using FrbaCrucero.Model.Cruceros;
using FrbaCrucero.Model.Recorridos;
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
    public partial class GenerarViaje : Form,ICrucero
    {
        Recorrido recorrido;
        DateTime salida;
        DateTime llegada;
        Crucero crucero;
        public GenerarViaje()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void generarViaje() 
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GenerarViaje");
            cmd.Parameters.Add("@fecha_salida",SqlDbType.DateTime2).Value = salida;
            cmd.Parameters.Add("@fecha_llegada", SqlDbType.DateTime2).Value = llegada;
            cmd.Parameters.Add("@recorrido_id", SqlDbType.Int).Value = recorrido.id;
            cmd.Parameters.Add("@crucero_id", SqlDbType.Int).Value = crucero.cruc_id;
            Database.executeProcedure(cmd);
        }


        public void updateCrucero(Crucero crucero)
        {
            this.crucero = crucero;
            cruceroText.Text = crucero.cruc_nombre;
        }

        internal void updateRecorrido(Model.Recorridos.Recorrido recorrido)
        {
            this.recorrido = recorrido;
            recorridoText.Text = recorrido.codigo.ToString();
        }

        private void seleccionarRecorrido_Click(object sender, EventArgs e)
        {
            new SeleccionRecorrido(this).Show();
        }

        private void seleccionarCrucero_Click(object sender, EventArgs e)
        {
            new FormListadoCruceros(this,DateTime.Now,DateTime.Now.AddMonths(1)).Show();
        }

        private void btn_seleccionar_llegada_Click(object sender, EventArgs e)
        {
            panel_date.Visible = true;
        }

        private void btn_seleccionar_salida_Click(object sender, EventArgs e)
        {
            panel_date.Visible = true;
            //btn_aceptar.
        }

        private void btn_seleccionar_salida_Aceptar(object sender, EventArgs e)
        {
            panel_date.Visible = true;
            
        }

        private void btn_seleccionar_llegada_Aceptar(object sender, EventArgs e)
        {
            //DateTime llegada = monthCalendar;
        }


    }
}

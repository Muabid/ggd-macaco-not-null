﻿using FrbaCrucero.AbmCrucero;
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
            try
            {
                validate();

                SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GenerarViaje");
                cmd.Parameters.Add("@fecha_salida", SqlDbType.DateTime2).Value = salida;
                cmd.Parameters.Add("@fecha_llegada", SqlDbType.DateTime2).Value = llegada;
                cmd.Parameters.Add("@recorrido_id", SqlDbType.Int).Value = recorrido.id;
                cmd.Parameters.Add("@crucero_id", SqlDbType.Int).Value = crucero.cruc_id;
                Database.executeProcedure(cmd);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void validate()
        {
            String error = "";
            if (!this.ValidateChildren())
                error = error + "Faltan completar campos \n";
            
            if(salida > llegada)
               error = error + "Fecha de llegada anterior a la de salida";

            if (error.Length > 0)
                throw new Exception(error);
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
            //new FormListadoCruceros(this,DateTime.Now,DateTime.Now.AddMonths(1)).Show();
        }

        private void btn_seleccionar_llegada_Click(object sender, EventArgs e)
        {
            panel_date.Visible = true;
            btn_aceptar.Click -= btn_seleccionar_salida_Aceptar;
            btn_aceptar.Click += btn_seleccionar_llegada_Aceptar;
        }

        private void btn_seleccionar_salida_Click(object sender, EventArgs e)
        {
            panel_date.Visible = true;
            btn_aceptar.Click += btn_seleccionar_salida_Aceptar;
            btn_aceptar.Click -= btn_seleccionar_llegada_Aceptar;
            
        }

        private void btn_seleccionar_salida_Aceptar(object sender, EventArgs e)
        {
            salida = monthCalendar.SelectionStart.Add(dateTimePicker.Value.TimeOfDay);
            salidaText.Text = salida.ToString();
            resetPanel();
        }

      

        private void btn_seleccionar_llegada_Aceptar(object sender, EventArgs e)
        {
            llegada = monthCalendar.SelectionStart.Add(dateTimePicker.Value.TimeOfDay);
            llegadaText.Text = llegada.ToString();
            resetPanel();
        }

        private void resetPanel()
        {
            monthCalendar.SelectionStart = DateTime.Today;
            dateTimePicker.Value = DateTime.Today;
            panel_date.Visible = false;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            resetPanel();
        }

        private void field_Validating(object sender, CancelEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            Console.WriteLine(txtBox.Text);
            if (String.IsNullOrEmpty(txtBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtBox, "Campo requerido");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtBox, String.Empty);
            }
        }


    }
}
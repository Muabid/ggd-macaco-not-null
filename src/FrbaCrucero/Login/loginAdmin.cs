﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Login
{
    public partial class LoginAdmin : Form
    {
      
        public LoginAdmin()
        {
            InitializeComponent();
            passwordTextBox.PasswordChar = '*';
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.LogearUsuario ");
                procedure.Parameters.Add("@username", SqlDbType.NVarChar).Value = usuarioTextBox.Text;
                procedure.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordTextBox.Text;
                Utils.Database.executeProcedure(procedure);

                SqlCommand cmd = Utils.Database.createCommand("[MACACO_NOT_NULL].ComprobarVigenciaReservasDelSistema2");
                cmd.Parameters.Add("@fecha_sistema", SqlDbType.DateTime2).Value = DateTime.Parse(ConfigurationManager.AppSettings["DATE"]);
                Utils.Database.executeProcedure(cmd);
                this.Close();
                

                new PantallaPrincipal("ADMINISTRADOR").ShowDialog();
                


            }
            catch (Exception exception) {

                MessageBox.Show(exception.Message);
            
            
            }

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

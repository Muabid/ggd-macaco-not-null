﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Login
{
    public partial class loginAdmin : Form
    {
        public loginAdmin()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand procedure = Utils.Database.createCommand("MACACO_NOT_NULL.LogearUsuario ");
                procedure.Parameters.Add("@username", SqlDbType.NVarChar).Value = usuarioTextBox.Text;
                procedure.Parameters.Add("@password", SqlDbType.NVarChar).Value = passwordTextBox.Text;
                Utils.Database.executeProcedure(procedure);
                PantallaPrincipal pantalla = new PantallaPrincipal();
                pantalla.Show();
                this.Close();

            }
            catch (Exception exception) {

                MessageBox.Show(exception.Message);
            
            
            }

        }
    }
}
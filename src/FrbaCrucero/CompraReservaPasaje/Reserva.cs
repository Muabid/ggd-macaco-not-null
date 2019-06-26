﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Reserva : Form
    {

        private Model.CompraReservaPasaje.Cliente cliente;
        private List<int> cabinasId;
        private int crucero;
        private Model.CompraReservaPasaje.Cliente loCliente;
        private DataTable cabinas;
        private Model.Viajes.Viaje crucero1;


        public Reserva(Model.CompraReservaPasaje.Cliente cliente, List<int> cabinasId, int crucero)
        {

            this.cliente = cliente;
            this.cabinasId = cabinasId;
            this.crucero = crucero;
            InitializeComponent();

            textBox1.Text = cliente.dni.ToString();
            textBox2.Text = cliente.direccion;
            textBox3.Text = cliente.telefono.ToString();
            textBox4.Text = cliente.nombreApellido;
            textBox5.Text = cliente.mail;
            textBox6.Text = cliente.fechaNacimiento.ToString();
            textBox7.Text = crucero.ToString();


        }

        public Reserva(Model.CompraReservaPasaje.Cliente loCliente, DataTable cabinas, Model.Viajes.Viaje crucero1)
        {
            // TODO: Complete member initialization
            this.loCliente = loCliente;
            this.cabinas = cabinas;
            this.crucero1 = crucero1;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }
    }
}

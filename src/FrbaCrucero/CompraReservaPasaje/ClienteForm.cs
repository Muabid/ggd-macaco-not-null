using FrbaCrucero.Model.Viajes;
﻿using FrbaCrucero.Model.CompraReservaPasaje;
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
using FrbaCrucero.Model.Cruceros;

namespace FrbaCrucero.CompraReservaPasaje
{

    public partial class ClienteForm : Form
    {
        public int usua_id;
        public List<Cabina> cabinas;
        public Viaje viaje;

        public ClienteForm(List<Cabina> cabinas, Viaje viaje)
        {
            InitializeComponent();
            this.cabinas = cabinas;
            this.viaje = viaje;
        }

        private void txt_dni_LostFocus(object sender, System.EventArgs e)
        {
            MessageBox.Show("hola");            
        }

        private void clientesConDNI(string dni)
        {
            //DataTable dataTable = new DataTable();
            //using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].UsuariosConDNI", Database.getConnection()))
            //using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            //{
            //    command.CommandType = CommandType.StoredProcedure;
            //    command.Parameters.Add(new SqlParameter("@dni", SqlDbType.Decimal));
            //    command.Parameters["@dni"].Value = System.Convert.ToDecimal(dni);            
            //    try
            //    {
            //        dataAdapter.Fill(dataTable);
            //    }
            //    catch (SqlException e)
            //    {
            //        throw new Exception(e.Message, e);
            //    }
            //}
            //return dataTable;
        }

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
           //s dataGridUsuarios.DataSource = clientesConDNI(txt_dni.Text);

        }

        private void txt_dni_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txt_dni.Text))
            {

                SqlCommand command = Database.createCommand(" select usua_id, concat(usua_nombre ,' ' ,usua_apellido) as usua_nombre,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac from MACACO_NOT_NULL.USUARIO where usua_dni = '" + txt_dni.Text + "';");
                DataTable data = Database.getData(command);
                if (data.Rows.Count > 0)
                {
                    var usuario = data.Rows[0];
                    this.usua_id = int.Parse(usuario["usua_id"].ToString());
                    txt_nombre_apellido.Text = usuario["usua_nombre"].ToString();
                    txt_telefono.Text = usuario["usua_telefono"].ToString();
                    txt_mail.Text = usuario["usua_mail"].ToString();
                    txt_direccion.Text = usuario["usua_direccion"].ToString();
                    txt_fecha_alta.Text = usuario["usua_fecha_nac"].ToString();
                }
            }

        }

        private void txt_fecha_alta_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            txt_fecha_alta.Text = this.monthCalendar1.SelectionRange.Start.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dni;
            if (txt_dni.Text != "")
            {
                 dni = int.Parse(txt_dni.Text);
            }
            else
            {
                 dni = 0;
            }
            String array = txt_nombre_apellido.Text;
            String[] otro = array.Split(',');   
            String nombre = otro[1];
            String apellido = otro[2];    
            //EL original
            SqlCommand command = Database.createCommand(" select usua_id," +
            "concat(usua_nombre ,' ' ,usua_apellido) as usua_nombre,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac from MACACO_NOT_NULL.USUARIO where usua_dni = '" + txt_dni.Text + "';");

            //El neuvo para que cuando busque cree uno nuevo

            SqlCommand command2 = Database.createCommand("IF NOT EXISTS (select 1 from MACACO_NOT_NULL.USUARIO where usua_dni =" + txt_dni.Text + " )" +
   "BEGIN " +
     "INSERT INTO MACACO_NOT_NULL.USUARIO (usua_nombre,usua_apellido,usua_dni,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac) VALUES("+ nombre +";"+apellido+","+ ")" +
   "END" +
   "ELSE" +
   "select usua_id," +
               "concat(usua_nombre ,' ' ,usua_apellido) as usua_nombre,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac from MACACO_NOT_NULL.USUARIO where usua_dni = '" + txt_dni.Text + "';" +
   "END");



            String var_nombre_apellido = txt_nombre_apellido.Text;
            String direccion = txt_direccion.Text;
            int telefono = int.Parse(txt_telefono.Text);
            String mail = txt_mail.Text;
            DateTime fecha_alta = DateTime.Parse(txt_fecha_alta.Text);

            Cliente elCliente = new Cliente(this.usua_id,dni, var_nombre_apellido, direccion, telefono, mail, fecha_alta);

            Pago form = new Pago(elCliente, cabinas, viaje);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni =int.Parse(txt_dni.Text);
            String var_nombre_apellido = txt_nombre_apellido.Text;
            String direccion = txt_direccion.Text;
            int telefono = int.Parse(txt_telefono.Text);
            String mail = txt_mail.Text;
            DateTime fecha_alta = DateTime.Parse(txt_fecha_alta.Text);

            Cliente loCliente = new Model.CompraReservaPasaje.Cliente(this.usua_id,dni,var_nombre_apellido,direccion,telefono,mail,fecha_alta);

            Reserva form2 = new Reserva(loCliente, cabinas, viaje);
            form2.Show();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            ElegirCabinas trom = new ElegirCabinas(this.viaje);
            trom.Show();
            this.Close();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }

      ///  this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
     //
    }
}

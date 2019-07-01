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

                SqlCommand command = Database.createCommand(" select usua_id, usua_nombre,usua_apellido,usua_direccion,usua_telefono,usua_mail,usua_fecha_nac from MACACO_NOT_NULL.USUARIO where usua_dni = '" + txt_dni.Text + "';");
                DataTable data = Database.getData(command);
                if (data.Rows.Count > 0)
                {
                    var usuario = data.Rows[0];
                    this.usua_id = int.Parse(usuario["usua_id"].ToString());
                    txt_nombre.Text = usuario["usua_nombre"].ToString();
                    txt_apellido.Text = usuario["usua_apellido"].ToString();
                    txt_telefono.Text = usuario["usua_telefono"].ToString();
                    txt_mail.Text = usuario["usua_mail"].ToString();
                    txt_direccion.Text = usuario["usua_direccion"].ToString();
                    txt_fecha_alta.Text = usuario["usua_fecha_nac"].ToString();
                }
                else
                {
                    
                    txt_nombre.Text = "";
                    txt_apellido.Text = "";
                    txt_telefono.Text = "";
                    txt_mail.Text = "";
                    txt_direccion.Text = "";
                    txt_fecha_alta.Text = "";
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
                if (c is MonthCalendar)
                    ((MonthCalendar)c).Visible = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            //txt_fecha_alta.Text = this.monthCalendar1.SelectionRange.Start.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
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

            foreach (Control c in groupBox1.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text))
                    {
                        throw new Exception("Requiere completar todos los datos");
                    }
                }

            }

            String nombre = txt_nombre.Text;
            String apellido = txt_apellido.Text;
            
            String direccion = txt_direccion.Text;
            int telefono = int.Parse(txt_telefono.Text);
            String mail = txt_mail.Text;
            DateTime fecha_alta = DateTime.Parse(txt_fecha_alta.Text);
            //EL original

            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].CreteOrUpdateCliente");
            cmd.Parameters.Add("@dni",SqlDbType.Decimal).Value = dni;
            cmd.Parameters.Add("@nombre",SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido",SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@direccion",SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@mail",SqlDbType.NVarChar).Value = mail;
            cmd.Parameters.Add("@nacimiento",SqlDbType.DateTime2).Value = fecha_alta;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
            Database.executeProcedure(cmd);
            SqlCommand cmdCli =  Database.createCommand("SELECT usua_id FROM MACACO_NOT_NULL.USUARIO WHERE usua_dni = @dni");
            cmdCli.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            usua_id = Database.executeScalar(cmdCli);

            Cliente elCliente = new Cliente(this.usua_id,dni,nombre+" " + apellido, direccion, telefono, mail, fecha_alta);

            SqlCommand cmd1 = Database.createCommand("[MACACO_NOT_NULL].VerificarViajeYaRerservadOComprado");
            cmd1.Parameters.Add("@usua_id", SqlDbType.Int).Value = usua_id;
            cmd1.Parameters.Add("@viaje_id", SqlDbType.Int).Value = viaje.id;
            Database.executeProcedure(cmd1);

            Pago form = new Pago(elCliente, cabinas, viaje);
            form.Show(this);
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                foreach (Control c in groupBox1.Controls)
                {
                    if (c is TextBox)
                    {
                        if (String.IsNullOrEmpty(c.Text))
                        {
                            throw new Exception("Requiere completar todos los datos");
                        }
                    }

                }
                int dni = int.Parse(txt_dni.Text);
                String nombre = txt_nombre.Text;
                String apellido = txt_apellido.Text;
                String direccion = txt_direccion.Text;
                int telefono = int.Parse(txt_telefono.Text);
                String mail = txt_mail.Text;
                DateTime fecha_alta = DateTime.Parse(txt_fecha_alta.Text);




                SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].CreteOrUpdateCliente");
                cmd.Parameters.Add("@dni", SqlDbType.Decimal).Value = dni;
                cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
                cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
                cmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
                cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = mail;
                cmd.Parameters.Add("@nacimiento", SqlDbType.DateTime2).Value = fecha_alta;
                cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;
                Database.executeProcedure(cmd);

                Cliente loCliente = new Model.CompraReservaPasaje.Cliente(this.usua_id, dni, nombre + " "+ apellido, direccion, telefono, mail, fecha_alta);

                SqlCommand cmd1 = Database.createCommand("[MACACO_NOT_NULL].VerificarViajeYaRerservadOComprado");
                cmd1.Parameters.Add("@usua_id", SqlDbType.Int).Value = usua_id;
                cmd1.Parameters.Add("@viaje_id", SqlDbType.Int).Value = viaje.id;
                Database.executeProcedure(cmd1);

                Reserva form2 = new Reserva(loCliente, cabinas, viaje);
                form2.Show(this);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "ERROR",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            ElegirCabinas trom = new ElegirCabinas(this.viaje);
            this.Owner.Show();
            this.Close();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txt_fecha_alta.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            monthCalendar1.Visible = false;
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ',') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ',') && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

      ///  this.textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource; 
     //
    }
}

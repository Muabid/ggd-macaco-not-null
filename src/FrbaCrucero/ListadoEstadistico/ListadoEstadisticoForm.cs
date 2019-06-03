using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class ListadoEstadisticoForm : Form
    {
        public ListadoEstadisticoForm()
        {
            InitializeComponent();
            semestre.Items.Add("1");
            semestre.Items.Add("2");
            tipoListado.Items.Add("Recorridos con más pasajes comprados");
            tipoListado.Items.Add("Recorridos con más cabinas libres en sus viajes");
            tipoListado.Items.Add("Cruceros con mayor cantidad de días fuera de servicio");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void semestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

            gridResultados.Columns.Clear();
            if (checkearFiltros())
            {
                
                //TODO separar en clases
                switch (tipoListado.SelectedItem.ToString())
                {
                    case "Recorridos con más pasajes comprados":
                        gridResultados.DataSource = recorridosMasVendidos(anio.Text,semestre.SelectedItem.ToString());                        
                        break;
                    case "Recorridos con más cabinas libres en sus viajes":
                        gridResultados.DataSource = recorridosConMasCabinasLibresEnSusViajes(anio.Text, semestre.SelectedItem.ToString());
                        break;
                    case "Cruceros con mayor cantidad de días fuera de servicio":
                        gridResultados.DataSource = crucerosConMasReparaciones(anio.Text, semestre.SelectedItem.ToString());
                        break;
                }

                gridResultados.Columns.Add(new DataGridViewButtonColumn()
                {
                    Name ="Ver",
                    Text = "Ver",
                    UseColumnTextForButtonValue = true
                });

                if(gridResultados.Rows.Count == 0)
                    MessageBox.Show("No se han encontrado datos.", "",
                        System.Windows.Forms.MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Los filtros ingresados son inválidos.", "Error", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        private object crucerosConMasReparaciones(string anio, string semestre)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].CrucerosConMasReparaciones", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@anio", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@semestre", SqlDbType.Int));
                command.Parameters["@anio"].Value = Int32.Parse(anio);
                command.Parameters["@semestre"].Value = Int32.Parse(semestre);
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            return dataTable;
            // throw new NotImplementedException();
        }

        private object recorridosConMasCabinasLibresEnSusViajes(string anio, string semestre)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].RecorridosConMasCabinasLibresEnSusViajes", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@anio", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@semestre", SqlDbType.Int));
                command.Parameters["@anio"].Value = Int32.Parse(anio);
                command.Parameters["@semestre"].Value = Int32.Parse(semestre);
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            return dataTable;
        }

        private object recorridosMasVendidos(string anio,string semestre)
        {
            DataTable dataTable = new DataTable();
            using(SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].RecorridosConMasPasajesComprados", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@anio", SqlDbType.Int));
                command.Parameters.Add(new SqlParameter("@semestre", SqlDbType.Int));
                command.Parameters["@anio"].Value = Int32.Parse(anio);
                command.Parameters["@semestre"].Value = Int32.Parse(semestre);
                try
                {
                    dataAdapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    throw new Exception(e.Message, e);
                }
            }
            return dataTable;
        }
        

        private bool checkearFiltros()
        {
           return this.ValidateChildren(ValidationConstraints.Enabled);
        }

        private void anio_Validating(object sender, CancelEventArgs e)
        {
            if (validateAnio())
            {
                e.Cancel = false;
                anioErrorProvider.SetError(this.anio, String.Empty);
            }
            else
            {
                e.Cancel = true;
                anioErrorProvider.SetError(this.anio, "Debe ingresar el año");
            }
        }

        private bool validateAnio()
        {
            return !String.IsNullOrEmpty(anio.Text);
        }

        private void semestre_Validating(object sender, CancelEventArgs e)
        {
            if (semestre.SelectedItem != null)
            {
                e.Cancel = false;
                semestreErrorProvider.SetError(this.semestre, String.Empty);
            }
            else
            {
                e.Cancel = true;
                semestreErrorProvider.SetError(this.semestre, "Debe indicar el semestre");
            }
        }

        private void tipoListado_Validating(object sender, CancelEventArgs e)
        {
            if (semestre.SelectedItem != null)
            {
                e.Cancel = false;
                tipoErrorProvider.SetError(this.tipoListado, String.Empty);
            }
            else
            {
                e.Cancel = true;
                tipoErrorProvider.SetError(this.tipoListado, "Debe ingresar la categoría");
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            this.gridResultados.DataSource = new DataTable();
            this.anio.Clear();
            this.semestre.SelectedIndex = -1;
            this.tipoListado.SelectedIndex = -1;
        }

        private void gridResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= gridResultados.Rows.Count -1)
            {
                return;
            }
           
            if (e.ColumnIndex == gridResultados.Columns["Ver"].Index)
            {

                switch (tipoListado.SelectedItem.ToString())
                {
                    case "Recorridos con más pasajes comprados":
                        Decimal codRecorrido = Convert.ToDecimal(gridResultados[1, e.RowIndex].Value);
                        Decimal precio = new RecorridoDAO().precioRecorrido(codRecorrido);
                        new RecorridoForm().show(codRecorrido, precio);
                        break;
                    case "Recorridos con más cabinas libres en sus viajes":
                        gridResultados.DataSource = recorridosConMasCabinasLibresEnSusViajes(anio.Text, semestre.SelectedItem.ToString());
                        break;
                    case "Cruceros con mayor cantidad de días fuera de servicio":
                        gridResultados.DataSource = crucerosConMasReparaciones(anio.Text, semestre.SelectedItem.ToString());
                        break;
                }
               
            }

        }



    }
}

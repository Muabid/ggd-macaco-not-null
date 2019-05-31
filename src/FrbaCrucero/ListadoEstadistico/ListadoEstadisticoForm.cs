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
            if (!checkearFiltros())
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
            }
            else
            {
                MessageBox.Show("Los filtros ingresados son inválidos.", "Error", System.Windows.Forms.MessageBoxButtons.OK);
            }
        }

        private object crucerosConMasReparaciones(string p1, string p2)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].CrucerosConMasReparaciones", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                // this.AddInputParametersToCommandIfTheyAreNotNull(inputParameters, command);

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

        private object recorridosConMasCabinasLibresEnSusViajes(string p1, string p2)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand("[MACACO_NOT_NULL].RecorridosConMasCabinasLibresEnSusViajes", Database.getConnection()))
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
            {
                command.CommandType = CommandType.StoredProcedure;
                // this.AddInputParametersToCommandIfTheyAreNotNull(inputParameters, command);

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
               // this.AddInputParametersToCommandIfTheyAreNotNull(inputParameters, command);

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
            if (semestre.SelectedItem == null)
            {
                return true;
            }
            return (semestre.SelectedItem.ToString() != "1" && semestre.SelectedItem.ToString() != "2") || tipoListado.SelectedItem == null
                || anio.Text == null || semestre.SelectedItem.ToString() == null ;
                //throw new NotImplementedException();
        }
    }
}

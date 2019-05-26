﻿using FrbaCrucero.Model.Recorridos;
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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class BajaRecorrido : Form
    {

        private RecorridoDAO recorridoDao = new RecorridoDAO();
        private PuertoDAO puertoDao = new PuertoDAO();
        public BajaRecorrido()
        {
            InitializeComponent();
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                ciudadOrigenCombo.Items.Add(puerto.nombre);
                ciudadDestinoCombo.Items.Add(puerto.nombre);
            }
           
        }

        private void onBuscar(object sender, EventArgs e)
        {
            String codigo = codigoField.Text;
            String origen = (String)ciudadOrigenCombo.SelectedItem;
            String destino = (String)ciudadDestinoCombo.SelectedItem;
            
            recorridosTable.DataSource = recorridoDao.getRecorridos(codigo,origen,destino);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void recorridosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Decimal codRecorrido = Convert.ToDecimal(recorridosTable["codigoColumn", e.RowIndex].Value);
            if (e.ColumnIndex == recorridosTable.Columns["verColumn"].Index)
            {
                                  
            }
            else if (e.ColumnIndex == recorridosTable.Columns["baja"].Index)
            {
            }

        }
    }
}

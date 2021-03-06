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
            }
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                ciudadDestinoCombo.Items.Add(puerto.nombre);
            }
           
        }

        private void onBuscar(object sender, EventArgs e)
        {
            String codigo = codigoBox.Text;
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
               
                Decimal precio = Convert.ToDecimal(recorridosTable["precioColumn", e.RowIndex].Value);
                new RecorridoForm().show(codRecorrido, precio);                  
            }
            else if (e.ColumnIndex == recorridosTable.Columns["bajaColumn"].Index)
            {
                try
                {
                    recorridoDao.darDeBaja(codRecorrido);
                    recorridosTable.Rows.RemoveAt(e.RowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }

        }

        private void limpiar_Click(object sender, EventArgs e)
        {

            DataTable dt =(DataTable) this.recorridosTable.DataSource;
            if(dt!=null)
                dt.Clear();
            this.codigoBox.Clear();
            this.ciudadDestinoCombo.SelectedIndex = -1;
            this.ciudadOrigenCombo.SelectedIndex = -1;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void BajaRecorrido_Load(object sender, EventArgs e)
        {

        }

    }
}

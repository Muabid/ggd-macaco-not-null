﻿using FrbaCrucero.Model.Recorridos;
using FrbaCrucero.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class ListadoModificacionRecorrido : Form
    {
        private RecorridoDAO recorridoDao = new RecorridoDAO();
        private PuertoDAO puertoDao = new PuertoDAO();
        public ListadoModificacionRecorrido()
        {
           
            InitializeComponent();
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                origenCombo.Items.Add(puerto.nombre);
            }
            foreach (Puerto puerto in puertoDao.getPuertos())
            {
                destinoCombo.Items.Add(puerto.nombre);
            }
        }

        private void limpiarButton_Click(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)this.recorridosTable.DataSource;
            if(dt!=null)
                dt.Clear();
            this.codigoBox.Clear();
            this.destinoCombo.SelectedIndex = -1;
            this.origenCombo.SelectedIndex = -1;

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {

            String codigo = codigoBox.Text;
            String origen = (String)origenCombo.SelectedItem;
            String destino = (String)destinoCombo.SelectedItem;

            recorridosTable.DataSource = recorridoDao.getRecorridos(codigo, origen, destino);
            
        
        }

        private void recorridosTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            Decimal codRecorrido = Convert.ToDecimal(recorridosTable["codigoColumn", e.RowIndex].Value);
            object precioV = recorridosTable["precioColumn", e.RowIndex].Value;
            Decimal precio = Convert.ToDecimal(precioV == DBNull.Value ? 0 : precioV);
            if (e.ColumnIndex == recorridosTable.Columns["modificarColumn"].Index)
            {
                new ModificacionRecorrido(this, codRecorrido, precio).Show(this);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            this.buscarButton_Click(null, null);
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}

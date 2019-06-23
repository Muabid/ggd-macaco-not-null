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
    public partial class RecorridoForm : Form
    {
        private RecorridoDAO recorridoDao = new RecorridoDAO();
        public RecorridoForm()
        {
            InitializeComponent();
        }

        private void TramosLista_Load(object sender, EventArgs e)
        {

        }

        public void show(Decimal codigoRecorrido, Decimal precio)
        {
           tramosTable.DataSource = recorridoDao.getTramos(codigoRecorrido);
           codigoBox.Text = codigoRecorrido.ToString();
           precioBox.Text = precio.ToString(); 
           this.ShowDialog();
          
        }

        public void Show(Form form, Decimal codigoRecorrido)
        {
            tramosTable.DataSource = recorridoDao.getTramos(codigoRecorrido);
            codigoBox.Text = codigoRecorrido.ToString();
            precioBox.Text = recorridoDao.precioRecorrido(codigoRecorrido).ToString();
            this.ShowDialog(form);
            
        }

    }
}

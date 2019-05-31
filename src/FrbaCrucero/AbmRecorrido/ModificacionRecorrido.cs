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
    public partial class ModificacionRecorrido : Form
    {

        private RecorridoDAO recorridoDao = new RecorridoDAO();
        private ListadoModificacionRecorrido listadoRecorridos;
        public ModificacionRecorrido(ListadoModificacionRecorrido _listadoRecorridos)
        {
            InitializeComponent();
            listadoRecorridos = _listadoRecorridos;
        }


        public void show(Decimal codigoRecorrido, Decimal precio)
        {
            tramosTable.DataSource = recorridoDao.getTramos(codigoRecorrido);
            codigoText.Text = codigoRecorrido.ToString();
            precioText.Text = precio.ToString();
            this.ShowDialog();

        }
    }
}

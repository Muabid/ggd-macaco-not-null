using FrbaCrucero.Model.Cruceros;
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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class MediosDeLosPagos : Form
    {
        private Model.CompraReservaPasaje.Cliente cliente;
        private List<Cabina> cabinas;
        private int crucero;
        private Model.Viajes.Viaje viaje;
        
         
        //  private DataTable cabinas;


        public MediosDeLosPagos(Model.CompraReservaPasaje.Cliente cliente, List<Cabina> cabinasId, Model.Viajes.Viaje viaje)
        {

            this.cliente = cliente;
            this.cabinas = cabinasId;
            this.viaje = viaje;
            InitializeComponent();
            descripcion.Items.AddRange(new object[]{"TARJETA VISA", "TARJETA MASTERCARD", "TARJETA AMERICANEXPRESS", "TARJETA CREDENCIAL"});
            cantCuotas.Items.AddRange(new object[]{1, 2, 3, 6, 12});
        }

        // public MediosDeLosPagos(Model.CompraReservaPasaje.Cliente cliente, DataTable cabinas, int crucero)
        //   {
        // TODO: Complete member initialization
        //       this.cliente = cliente;
        //       this.cabinas = cabinas;
        //       this.crucero = crucero;
        //    }

        private void botonPagar_Click(object sender, EventArgs e)
        {
            
             SqlCommand procedure = Utils.Database.createCommand(" INSERT INTO [MACACO_NOT_NULL].[PAGO] (pago_usuario_id) VALUES "+ "("+cliente.id.ToString()+")");
             Utils.Database.execute(procedure);


             foreach (DataGridViewRow row in tablaMediosDePago.Rows)
             {
                 int var_cuotas = int.Parse(row.Cells["cuotas"].Value.ToString());
                 String var_descripcion = row.Cells["methodOfPayment"].Value.ToString();

                 SqlCommand procedure2 = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarMedioDePago_Al_NuevoPago");

                 procedure2.Parameters.Add("@medio_Pago", SqlDbType.NVarChar).Value = var_descripcion;
                 procedure2.Parameters.Add("@cantidad_cuotas", SqlDbType.Int).Value = var_cuotas;
                 Utils.Database.executeProcedure(procedure2);
             }

             for (int i = 0; i < cabinas.Count; i++)
             {
                 Cabina unaCabina = cabinas.ElementAt(i);
                 int cabi_id = unaCabina.cabi_id;
                 SqlCommand procedure2 = Utils.Database.createCommand("MACACO_NOT_NULL.AgregarPasajeA_Cliente");
                 procedure2.Parameters.Add("@cab_id_pasaje", SqlDbType.Int).Value = cabi_id;
                 procedure2.Parameters.Add("@viaje_id_pasaje", SqlDbType.Int).Value = viaje.id;
                 procedure2.Parameters.Add("@fecha_sistema", SqlDbType.DateTime2).Value = ConfigurationUtils.Today();
                 Utils.Database.executeProcedure(procedure2);
                    
             }
             if (tablaMediosDePago.Rows.Count > 0 && cabinas.Count > 0)
             {

                 SqlCommand maxPago = Utils.Database.createCommand("SELECT  max (pago_id) from MACACO_NOT_NULL.PAGO;");
                 int escalar = Utils.Database.executeScalar(maxPago);

                 MessageBox.Show("Pago Realizado - Codigo: " + escalar.ToString());
                 this.Close();
             }
             else
             {
                 MessageBox.Show("No se eligieron cabinas o medios de pago");
             }


        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(descripcion.Text) || String.IsNullOrEmpty(cantCuotas.Text))
                {
                    throw new Exception("Requiere completar todos los datos");
                }
                else
                {
                    String cuotas = cantCuotas.Text;
                    String variable = descripcion.Text;

                    string[] new_row = new string[2];
                    new_row[0] = variable;
                    new_row[1] = cuotas;
                    tablaMediosDePago.Rows.Add(new_row);
                    cantCuotas.SelectedIndex = -1;
                    descripcion.SelectedIndex = -1;

                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MediosDeLosPagos_Load(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void tablaMediosDePago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == tablaMediosDePago.Columns["columnButtonDelete"].Index)
                {
                    tablaMediosDePago.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void cantCuotas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
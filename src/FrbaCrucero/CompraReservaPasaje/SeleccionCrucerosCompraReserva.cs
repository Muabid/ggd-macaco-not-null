using FrbaCrucero.CompraReservaPasaje;
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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class SeleccionCrucerosCompraReserva : Form
    {
        private CruceroDAO dao = new CruceroDAO();
        public SeleccionCrucerosCompraReserva()
        {
            InitializeComponent();

        }

        private void FormListadoCruceros_Load(object sender, EventArgs e)
        {
            var companias = dao.getCompanias().ToArray();
            cbo_compania.Items.AddRange(companias);

            var modelos = dao.getModelos().ToArray();
            cbo_modelo.Items.AddRange(modelos);

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = Database.createCommand("[MACACO_NOT_NULL].GetCruceros2");          
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = Database.orDbNull(txt_nombre.Text);
            cmd.Parameters.Add("@modelo", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_modelo.Text);
            cmd.Parameters.Add("@compania", SqlDbType.NVarChar).Value = Database.orDbNull(cbo_compania.Text);
            dgv_cruceros.DataSource = Database.getDataProcedure(cmd);
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_compania_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_cabinas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_cruceros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_cruceros.Columns["seleccionar"].Index)
                {
                    ComprarOReservarPasaje parent = (ComprarOReservarPasaje)this.Owner;
                    Crucero crucero = new Crucero();
                    crucero.cruc_id = int.Parse(dgv_cruceros["cruc_id", e.RowIndex].Value.ToString());
                    crucero.cruc_nombre = dgv_cruceros["cruc_nombre", e.RowIndex].Value.ToString();
                    parent.updateCrucero(crucero);
                    this.Close();
                }

            }
        }
        
    }
}

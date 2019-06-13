using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using FrbaCrucero.Model.Roles;
using FrbaCrucero.Utils;
using FrbaCrucero.Login;

namespace FrbaCrucero
{
    public partial class PantallaPrincipal : Form
    {

        private Dictionary<String, Button> funcionalidades = new Dictionary<String,Button>();
        
        public PantallaPrincipal(String rol)
        {
            InitializeComponent();
            loadFuncionalidades();
            showFuncionalidades(rol);
        }

        private void showFuncionalidades(String rol)
        {
            SqlCommand command = FrbaCrucero.Utils.Database.createCommand("SELECT [func_detalle]" +
               " FROM [GD1C2019].[MACACO_NOT_NULL].[RolesXFuncionalidades] WHERE rol_nombre = @rol");
            command.Parameters.Add("@rol",SqlDbType.NChar).Value = rol;
            DataTable table = Utils.Database.getData(command);

            List<String> funcionalidadesRol = table.Rows.Cast<DataRow>().
                Select(row => row[0].ToString()).ToList<String>();

            funcionalidades.Where(f => !funcionalidadesRol.Contains(f.Key)).ToList().ForEach(f => { f.Value.Visible = false; });
        }

        private void loadFuncionalidades()
        {
            funcionalidades.Add("ABM de Rol", btnRol);
            funcionalidades.Add("ABM de Recorrido", btnRecorrido);
            funcionalidades.Add("ABM de Crucero", btnCrucero);
            funcionalidades.Add("Generar Viaje", btnGenerarViaje);
            funcionalidades.Add("Compra y/o reserva de viaje", btnPasaje);
            funcionalidades.Add("Pago Reserva", btnPagoReserva);
            funcionalidades.Add("Listado Estadístico", btnListadoEstadistico);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRol_Click(object sender, EventArgs e)
        {

        }

     
    }
}

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
using FrbaCrucero.AbmRol;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.ListadoEstadistico;
using FrbaCrucero.AbmCrucero;

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
            new RolAbm().Show(this);
        }

        private void btnRecorrido_Click(object sender, EventArgs e)
        {
            new RecorridoAbm().Show(this);
        }

        private void btnGenerarViaje_Click(object sender, EventArgs e)
        {
            new GenerarViaje().Show(this);
        }

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {
            new ListadoEstadisticoForm().Show(this);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            
            Owner.Show();    
            this.Close();
                  
        }

        private void btnCrucero_Click(object sender, EventArgs e)
        {
            new FormPantallaInicio().Show(this);
        }


     
    }
}

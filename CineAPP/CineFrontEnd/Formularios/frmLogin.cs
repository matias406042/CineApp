using CineFrontEnd.Servicios;
using CineFrontEnd.Servicios.Interfaz;

namespace CineFrontEnd
{
    public partial class frmLogin : Form
    {
        IServicio servicio;
        public frmLogin(FabricaServicio fabrica)
        {
            InitializeComponent();
        }

        private void frnPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
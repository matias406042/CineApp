using CineFrontEnd.Formularios;
using CineFrontEnd.Http;
using Newtonsoft.Json;
using CineBackEnd.Entidades;

namespace CineFrontEnd
{
    public partial class frmLogin : Form
    {
        List<Usuarios> usuarios;

        public frmLogin()
        {
            InitializeComponent();
            usuarios = new List<Usuarios>();
        }

        private async void frnPrincipal_Load(object sender, EventArgs e)
        {
            string url = "https://localhost:7168/Uuario/loguear";
            var result = await Cliente.GetInstance().GetAsync(url);
            var lst = JsonConvert.DeserializeObject<List<Usuarios>>(result);
            usuarios = lst;

        }

        private void cboxContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxContrasenia.Checked)
            {
                txtContrasenia.UseSystemPasswordChar = false;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            foreach (Usuarios u in usuarios)
            {
                if (u.User == txtUsuario.Text && u.Contra == txtContrasenia.Text)
                {
                    FrmMenu frm = new FrmMenu();
                    frm.ShowDialog();
                    this.Dispose();
                }

            }
            MessageBox.Show("Ha ingresado crecenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContrasenia_Enter(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "CONTRASENIA")
            {
                txtContrasenia.Text = "";
                txtContrasenia.ForeColor = Color.White;
                txtContrasenia.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasenia_Leave(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "")
            {
                txtContrasenia.Text = "CONTRASENIA";
                txtContrasenia.ForeColor = Color.DimGray;
                txtContrasenia.UseSystemPasswordChar = false;

            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
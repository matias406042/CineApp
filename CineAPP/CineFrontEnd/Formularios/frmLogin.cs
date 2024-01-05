using CineFrontEnd.Formularios;
using CineFrontEnd.Http;
using Newtonsoft.Json;
using CineBackEnd.Entidades;

namespace CineFrontEnd
{
    public partial class frmLogin : Form
    {
       

        public frmLogin()
        {
            InitializeComponent();
           
        }

        private async void frnPrincipal_Load(object sender, EventArgs e)
        {
          

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
        private async void btnLogin_Click(object sender, EventArgs e)
        {

            var u = new Usuarios(txtUsuario.Text,txtContrasenia.Text);

            await AsyncLoguearUsuario(u);


        }


        private async Task AsyncLoguearUsuario(Usuarios u)
        {
            string url = "https://localhost:7168/Usuario/loguear";
            var body = JsonConvert.SerializeObject(u);
            var result2 = await Cliente.GetInstance().PutAsync(url, body);
            if (result2.Equals("true"))
            {
                MessageBox.Show("acceso confirmado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var menu = new FrmMenu();
                menu.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Ha ingresado crecenciales incorrectas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
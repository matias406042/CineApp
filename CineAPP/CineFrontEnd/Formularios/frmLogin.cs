using CineFrontEnd.Formularios;

namespace CineFrontEnd
{
    public partial class frmLogin : Form
    {
       
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frnPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cboxContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxContrasenia.Checked)
            {
                txtContrasenia.PasswordChar = char.MinValue;
            }
            else { txtContrasenia.PasswordChar = char.Parse("*"); }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
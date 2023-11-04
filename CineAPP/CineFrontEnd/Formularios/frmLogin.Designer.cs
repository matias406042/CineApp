namespace CineFrontEnd
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogin = new Button();
            cboxContrasenia = new CheckBox();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(152, 36);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(247, 30);
            txtUsuario.TabIndex = 0;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(152, 97);
            txtContrasenia.Margin = new Padding(3, 4, 3, 4);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(247, 30);
            txtContrasenia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 47);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 101);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(293, 147);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(107, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboxContrasenia
            // 
            cboxContrasenia.AutoSize = true;
            cboxContrasenia.Location = new Point(26, 149);
            cboxContrasenia.Margin = new Padding(3, 4, 3, 4);
            cboxContrasenia.Name = "cboxContrasenia";
            cboxContrasenia.Size = new Size(158, 24);
            cboxContrasenia.TabIndex = 5;
            cboxContrasenia.Text = "Mostrar contraseña";
            cboxContrasenia.UseVisualStyleBackColor = true;
            cboxContrasenia.CheckedChanged += cboxContrasenia_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 193);
            Controls.Add(cboxContrasenia);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            Text = "Login";
            Load += frnPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private Label label1;
        private Label label2;
        private Button btnLogin;
        private CheckBox cboxContrasenia;
    }
}
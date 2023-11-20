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
            txtUsuario.Location = new Point(133, 27);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(217, 26);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasenia.Location = new Point(133, 73);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(217, 26);
            txtContrasenia.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(62, 18);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 76);
            label2.Name = "label2";
            label2.Size = new Size(89, 18);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(256, 110);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // cboxContrasenia
            // 
            cboxContrasenia.AutoSize = true;
            cboxContrasenia.Location = new Point(23, 112);
            cboxContrasenia.Name = "cboxContrasenia";
            cboxContrasenia.Size = new Size(128, 19);
            cboxContrasenia.TabIndex = 5;
            cboxContrasenia.Text = "Mostrar contraseña";
            cboxContrasenia.UseVisualStyleBackColor = true;
            cboxContrasenia.CheckedChanged += cboxContrasenia_CheckedChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 145);
            Controls.Add(cboxContrasenia);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
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
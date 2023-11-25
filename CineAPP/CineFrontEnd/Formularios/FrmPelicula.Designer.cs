namespace CineFrontEnd.Formularios
{
    partial class FrmPelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboGenero = new ComboBox();
            cboClasificacion = new ComboBox();
            cboProductora = new ComboBox();
            txtTitulo = new TextBox();
            txtDuracion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpEstreno = new DateTimePicker();
            label6 = new Label();
            btnGuardar = new Button();
            btnClose = new Button();
            lblPelicula = new Label();
            panel1 = new Panel();
            lblMenu = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(276, 158);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(132, 28);
            cboGenero.TabIndex = 3;
            // 
            // cboClasificacion
            // 
            cboClasificacion.FormattingEnabled = true;
            cboClasificacion.Location = new Point(112, 285);
            cboClasificacion.Name = "cboClasificacion";
            cboClasificacion.Size = new Size(125, 28);
            cboClasificacion.TabIndex = 4;
            // 
            // cboProductora
            // 
            cboProductora.FormattingEnabled = true;
            cboProductora.Location = new Point(276, 285);
            cboProductora.Name = "cboProductora";
            cboProductora.Size = new Size(132, 28);
            cboProductora.TabIndex = 5;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(112, 159);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 0;
            txtTitulo.TextChanged += textBox1_TextChanged;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(562, 286);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(72, 27);
            txtDuracion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(148, 136);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(510, 262);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 6;
            label2.Text = "DURACION EN MINUTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(117, 263);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "CLASIFICACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(305, 136);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "GENERO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(291, 262);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 9;
            label5.Text = "PRODUCTORA";
            label5.Click += label5_Click;
            // 
            // dtpEstreno
            // 
            dtpEstreno.Location = new Point(468, 159);
            dtpEstreno.Name = "dtpEstreno";
            dtpEstreno.Size = new Size(273, 27);
            dtpEstreno.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(528, 136);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 11;
            label6.Text = "FECHA DE ESTRENO";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnGuardar.FlatAppearance.BorderSize = 3;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.LightGray;
            btnGuardar.Location = new Point(12, 404);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(115, 36);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(64, 64, 64);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.LightGray;
            btnClose.Location = new Point(697, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(91, 37);
            btnClose.TabIndex = 14;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Sitka Subheading", 25.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPelicula.ForeColor = Color.Ivory;
            lblPelicula.Location = new Point(170, 9);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(231, 62);
            lblPelicula.TabIndex = 15;
            lblPelicula.Text = "PELICULA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(lblMenu);
            panel1.ForeColor = Color.FromArgb(149, 1, 1);
            panel1.Location = new Point(-5, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 33);
            panel1.TabIndex = 16;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.LightGray;
            lblMenu.Location = new Point(24, 31);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(521, 54);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Top Films - Menú Principal";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(15, 15, 15);
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(72, 272);
            label7.Name = "label7";
            label7.Size = new Size(39, 41);
            label7.TabIndex = 17;
            label7.Text = "+";
            // 
            // FrmPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(800, 451);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(lblPelicula);
            Controls.Add(btnClose);
            Controls.Add(btnGuardar);
            Controls.Add(label6);
            Controls.Add(dtpEstreno);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDuracion);
            Controls.Add(txtTitulo);
            Controls.Add(cboProductora);
            Controls.Add(cboClasificacion);
            Controls.Add(cboGenero);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPelicula";
            Text = "Pelicula";
            Load += FrmPelicula_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboGenero;
        private ComboBox cboClasificacion;
        private ComboBox cboProductora;
        private TextBox txtTitulo;
        private TextBox txtDuracion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpEstreno;
        private Label label6;
        private Button btnGuardar;
        private Button btnClose;
        private Label lblPelicula;
        private Panel panel1;
        private Label lblMenu;
        private Label label7;
    }
}
namespace CineFrontEnd.Formularios
{
    partial class FrmMenu
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
            panelMenuLateral = new Panel();
            btnSalir = new Button();
            btnComprobantes = new Button();
            btnTickets = new Button();
            btnPeliculas = new Button();
            btnFunciones = new Button();
            panelLogo = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblMenu = new Label();
            panelMenuLateral.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.BackColor = Color.FromArgb(15, 15, 15);
            panelMenuLateral.Controls.Add(btnSalir);
            panelMenuLateral.Controls.Add(btnComprobantes);
            panelMenuLateral.Controls.Add(btnTickets);
            panelMenuLateral.Controls.Add(btnPeliculas);
            panelMenuLateral.Controls.Add(btnFunciones);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 2, 3, 2);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(221, 472);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.FromArgb(229, 9, 20);
            btnSalir.Location = new Point(46, 429);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(127, 34);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnComprobantes
            // 
            btnComprobantes.BackColor = Color.FromArgb(15, 15, 15);
            btnComprobantes.Dock = DockStyle.Top;
            btnComprobantes.FlatAppearance.BorderSize = 0;
            btnComprobantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnComprobantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnComprobantes.FlatStyle = FlatStyle.Flat;
            btnComprobantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprobantes.ForeColor = Color.LightGray;
            btnComprobantes.Location = new Point(0, 304);
            btnComprobantes.Name = "btnComprobantes";
            btnComprobantes.Size = new Size(221, 70);
            btnComprobantes.TabIndex = 8;
            btnComprobantes.Text = "VENTAS";
            btnComprobantes.UseVisualStyleBackColor = false;
            btnComprobantes.Click += btnComprobantes_Click;
            // 
            // btnTickets
            // 
            btnTickets.BackColor = Color.FromArgb(15, 15, 15);
            btnTickets.Dock = DockStyle.Top;
            btnTickets.FlatAppearance.BorderSize = 0;
            btnTickets.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnTickets.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnTickets.FlatStyle = FlatStyle.Flat;
            btnTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTickets.ForeColor = Color.LightGray;
            btnTickets.Location = new Point(0, 234);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(221, 70);
            btnTickets.TabIndex = 7;
            btnTickets.Text = "REPORTES";
            btnTickets.UseVisualStyleBackColor = false;
            btnTickets.Click += btnTickets_Click;
            // 
            // btnPeliculas
            // 
            btnPeliculas.BackColor = Color.FromArgb(15, 15, 15);
            btnPeliculas.Dock = DockStyle.Top;
            btnPeliculas.FlatAppearance.BorderSize = 0;
            btnPeliculas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnPeliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnPeliculas.FlatStyle = FlatStyle.Flat;
            btnPeliculas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPeliculas.ForeColor = Color.LightGray;
            btnPeliculas.Location = new Point(0, 164);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(221, 70);
            btnPeliculas.TabIndex = 6;
            btnPeliculas.Text = "PELICULAS";
            btnPeliculas.UseVisualStyleBackColor = false;
            btnPeliculas.Click += btnPeliculas_Click;
            // 
            // btnFunciones
            // 
            btnFunciones.BackColor = Color.FromArgb(15, 15, 15);
            btnFunciones.Dock = DockStyle.Top;
            btnFunciones.FlatAppearance.BorderSize = 0;
            btnFunciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnFunciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnFunciones.FlatStyle = FlatStyle.Flat;
            btnFunciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFunciones.ForeColor = Color.LightGray;
            btnFunciones.Location = new Point(0, 94);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(221, 70);
            btnFunciones.TabIndex = 5;
            btnFunciones.Text = "FUNCIONES";
            btnFunciones.UseVisualStyleBackColor = false;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(221, 94);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cineedit;
            pictureBox2.Location = new Point(-18, -10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cineedit;
            pictureBox1.Location = new Point(221, 98);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 372);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 9, 20);
            panel1.Controls.Add(lblMenu);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(229, 9, 20);
            panel1.Location = new Point(221, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 94);
            panel1.TabIndex = 1;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("PMingLiU-ExtB", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Black;
            lblMenu.Location = new Point(301, 38);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(107, 32);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "MENU";
            lblMenu.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(935, 472);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenuLateral;
        private Panel panelLogo;
        private Button btnFunciones;
        private Button btnComprobantes;
        private Button btnTickets;
        private Button btnPeliculas;
        private Panel panel1;
        private Label lblMenu;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
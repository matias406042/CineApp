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
            btnVentas = new Button();
            panelReportes = new Panel();
            btnRep_Peliculas = new Button();
            btnRep_Comprobantes = new Button();
            btnSalir = new Button();
            btnTickets = new Button();
            btnPeliculas = new Button();
            btnFunciones = new Button();
            panelLogo = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblMenu = new Label();
            panelFrms = new Panel();
            panelMenuLateral.SuspendLayout();
            panelReportes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panelFrms.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(15, 15, 15);
            panelMenuLateral.Controls.Add(btnVentas);
            panelMenuLateral.Controls.Add(panelReportes);
            panelMenuLateral.Controls.Add(btnSalir);
            panelMenuLateral.Controls.Add(btnTickets);
            panelMenuLateral.Controls.Add(btnPeliculas);
            panelMenuLateral.Controls.Add(btnFunciones);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Margin = new Padding(3, 2, 3, 2);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(221, 514);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnVentas
            // 
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.LightGray;
            btnVentas.Location = new Point(0, 374);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(221, 70);
            btnVentas.TabIndex = 11;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // panelReportes
            // 
            panelReportes.Controls.Add(btnRep_Peliculas);
            panelReportes.Controls.Add(btnRep_Comprobantes);
            panelReportes.Dock = DockStyle.Top;
            panelReportes.Location = new Point(0, 304);
            panelReportes.Name = "panelReportes";
            panelReportes.Size = new Size(221, 70);
            panelReportes.TabIndex = 10;
            panelReportes.Visible = false;
            // 
            // btnRep_Peliculas
            // 
            btnRep_Peliculas.Dock = DockStyle.Right;
            btnRep_Peliculas.FlatAppearance.BorderSize = 0;
            btnRep_Peliculas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRep_Peliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRep_Peliculas.FlatStyle = FlatStyle.Flat;
            btnRep_Peliculas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRep_Peliculas.ForeColor = Color.LightGray;
            btnRep_Peliculas.Location = new Point(111, 0);
            btnRep_Peliculas.Name = "btnRep_Peliculas";
            btnRep_Peliculas.Size = new Size(110, 70);
            btnRep_Peliculas.TabIndex = 1;
            btnRep_Peliculas.Text = "PELICULAS";
            btnRep_Peliculas.UseVisualStyleBackColor = true;
            btnRep_Peliculas.Click += btnRep_Peliculas_Click;
            // 
            // btnRep_Comprobantes
            // 
            btnRep_Comprobantes.Dock = DockStyle.Left;
            btnRep_Comprobantes.FlatAppearance.BorderSize = 0;
            btnRep_Comprobantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnRep_Comprobantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnRep_Comprobantes.FlatStyle = FlatStyle.Flat;
            btnRep_Comprobantes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRep_Comprobantes.ForeColor = Color.LightGray;
            btnRep_Comprobantes.Location = new Point(0, 0);
            btnRep_Comprobantes.Name = "btnRep_Comprobantes";
            btnRep_Comprobantes.Size = new Size(111, 70);
            btnRep_Comprobantes.TabIndex = 0;
            btnRep_Comprobantes.Text = "COMPROBANTES";
            btnRep_Comprobantes.UseVisualStyleBackColor = true;
            btnRep_Comprobantes.Click += btnRep_Comprobantes_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(50, 0, 0);
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(100, 1, 1);
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(0, 480);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(221, 34);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            panelLogo.Controls.Add(panel3);
            panelLogo.Controls.Add(panel2);
            panelLogo.Controls.Add(pictureBox2);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(221, 94);
            panelLogo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(221, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 472);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(221, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(714, 472);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(50, 0, 0);
            pictureBox2.Image = Properties.Resources.cineedit;
            pictureBox2.Location = new Point(-18, -10);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(254, 116);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cineedit;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(714, 420);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 0, 0);
            panel1.Controls.Add(lblMenu);
            panel1.ForeColor = Color.FromArgb(149, 1, 1);
            panel1.Location = new Point(221, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 94);
            panel1.TabIndex = 1;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.LightGray;
            lblMenu.Location = new Point(21, 23);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(420, 45);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Top Films - Menú Principal";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            lblMenu.Click += lblMenu_Click;
            // 
            // panelFrms
            // 
            panelFrms.BackColor = Color.Transparent;
            panelFrms.Controls.Add(pictureBox1);
            panelFrms.Location = new Point(221, 94);
            panelFrms.Name = "panelFrms";
            panelFrms.Size = new Size(711, 420);
            panelFrms.TabIndex = 4;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(932, 514);
            Controls.Add(panel1);
            Controls.Add(panelFrms);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            panelReportes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFrms.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panelMenuLateral;
        private Panel panelLogo;
        private Button btnFunciones;
        private Button btnTickets;
        private Button btnPeliculas;
        private Panel panel1;
        private Label lblMenu;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        public Panel panelFrms;
        private Panel panelReportes;
        private Button btnVentas;
        private Button btnRep_Peliculas;
        private Button btnRep_Comprobantes;
    }
}
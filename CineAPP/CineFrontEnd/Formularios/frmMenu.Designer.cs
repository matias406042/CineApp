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
            subPanelReportes = new Panel();
            button2 = new Button();
            btnReporteComprobante = new Button();
            btnSalir = new Button();
            btnTickets = new Button();
            btnPeliculas = new Button();
            btnFunciones = new Button();
            panelLogo = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            lblMenu = new Label();
            panelFrms = new Panel();
            pictureBox3 = new PictureBox();
            panelMenuLateral.SuspendLayout();
            subPanelReportes.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panelFrms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panelMenuLateral
            // 
            panelMenuLateral.AutoScroll = true;
            panelMenuLateral.BackColor = Color.FromArgb(15, 15, 15);
            panelMenuLateral.Controls.Add(btnVentas);
            panelMenuLateral.Controls.Add(subPanelReportes);
            panelMenuLateral.Controls.Add(btnSalir);
            panelMenuLateral.Controls.Add(btnTickets);
            panelMenuLateral.Controls.Add(btnPeliculas);
            panelMenuLateral.Controls.Add(btnFunciones);
            panelMenuLateral.Controls.Add(panelLogo);
            panelMenuLateral.Dock = DockStyle.Left;
            panelMenuLateral.Location = new Point(0, 0);
            panelMenuLateral.Name = "panelMenuLateral";
            panelMenuLateral.Size = new Size(253, 699);
            panelMenuLateral.TabIndex = 0;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(15, 15, 15);
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnVentas.ForeColor = Color.LightGray;
            btnVentas.Location = new Point(0, 525);
            btnVentas.Margin = new Padding(3, 4, 3, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(253, 86);
            btnVentas.TabIndex = 13;
            btnVentas.Text = "VENTAS";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click_1;
            // 
            // subPanelReportes
            // 
            subPanelReportes.BorderStyle = BorderStyle.FixedSingle;
            subPanelReportes.Controls.Add(button2);
            subPanelReportes.Controls.Add(btnReporteComprobante);
            subPanelReportes.Dock = DockStyle.Top;
            subPanelReportes.Location = new Point(0, 404);
            subPanelReportes.Name = "subPanelReportes";
            subPanelReportes.Size = new Size(253, 121);
            subPanelReportes.TabIndex = 12;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 0, 0);
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = Color.DarkGray;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightGray;
            button2.Location = new Point(0, 58);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(251, 62);
            button2.TabIndex = 2;
            button2.Text = "PELICULAS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnReporteComprobante
            // 
            btnReporteComprobante.BackColor = Color.FromArgb(192, 0, 0);
            btnReporteComprobante.Dock = DockStyle.Top;
            btnReporteComprobante.FlatAppearance.BorderColor = Color.DarkGray;
            btnReporteComprobante.FlatAppearance.MouseDownBackColor = Color.FromArgb(28, 28, 28);
            btnReporteComprobante.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            btnReporteComprobante.FlatStyle = FlatStyle.Flat;
            btnReporteComprobante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReporteComprobante.ForeColor = Color.LightGray;
            btnReporteComprobante.Location = new Point(0, 0);
            btnReporteComprobante.Margin = new Padding(3, 4, 3, 4);
            btnReporteComprobante.Name = "btnReporteComprobante";
            btnReporteComprobante.Size = new Size(251, 58);
            btnReporteComprobante.TabIndex = 1;
            btnReporteComprobante.Text = "COMPROBANTES";
            btnReporteComprobante.UseVisualStyleBackColor = false;
            btnReporteComprobante.Click += button1_Click;
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
            btnSalir.Location = new Point(0, 654);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(253, 45);
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
            btnTickets.Location = new Point(0, 311);
            btnTickets.Margin = new Padding(3, 4, 3, 4);
            btnTickets.Name = "btnTickets";
            btnTickets.Size = new Size(253, 93);
            btnTickets.TabIndex = 0;
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
            btnPeliculas.Location = new Point(0, 218);
            btnPeliculas.Margin = new Padding(3, 4, 3, 4);
            btnPeliculas.Name = "btnPeliculas";
            btnPeliculas.Size = new Size(253, 93);
            btnPeliculas.TabIndex = 4;
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
            btnFunciones.Location = new Point(0, 125);
            btnFunciones.Margin = new Padding(3, 4, 3, 4);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(253, 93);
            btnFunciones.TabIndex = 1;
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
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(253, 125);
            panelLogo.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(253, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(816, 629);
            panel3.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Location = new Point(253, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 629);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(15, 15, 15);
            pictureBox2.Image = Properties.Resources.cineedit;
            pictureBox2.Location = new Point(-21, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(290, 155);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            pictureBox2.DoubleClick += pictureBox2_DoubleClick;
            pictureBox2.MouseEnter += pictureBox2_MouseEnter;
            pictureBox2.MouseLeave += pictureBox2_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(lblMenu);
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(253, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 125);
            panel1.TabIndex = 1;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.BorderStyle = BorderStyle.Fixed3D;
            lblMenu.Font = new Font("Palatino Linotype", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.ForeColor = Color.Silver;
            lblMenu.Location = new Point(194, 28);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(368, 65);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menú Principal";
            lblMenu.TextAlign = ContentAlignment.MiddleCenter;
            lblMenu.Click += lblMenu_Click;
            // 
            // panelFrms
            // 
            panelFrms.BackColor = Color.Transparent;
            panelFrms.Controls.Add(pictureBox3);
            panelFrms.Location = new Point(253, 125);
            panelFrms.Margin = new Padding(3, 4, 3, 4);
            panelFrms.Name = "panelFrms";
            panelFrms.Size = new Size(816, 574);
            panelFrms.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.imagen_menu_top_films;
            pictureBox3.Location = new Point(-3, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(816, 578);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1068, 699);
            Controls.Add(panel1);
            Controls.Add(panelFrms);
            Controls.Add(panelMenuLateral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENU";
            Load += Form1_Load;
            panelMenuLateral.ResumeLayout(false);
            subPanelReportes.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelFrms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
        public Panel panelFrms;
        private Panel panelReportes;
        private Button btnRep_Peliculas;
        private Button btnRep_Comprobantes;
        private Button btnVentas;
        private Button button2;
        private Button btnReporteComprobante;
        private Panel subPanelReportes;
        private PictureBox pictureBox3;
    }
}
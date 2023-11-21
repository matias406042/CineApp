namespace CineFrontEnd.Formularios
{
    partial class FrmComprobante
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
            cboFormaPago = new ComboBox();
            lblFormaPago = new Label();
            dgvTickets = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColHorario = new DataGridViewTextBoxColumn();
            ColButaca = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            txtTotal = new TextBox();
            lblTotal = new Label();
            cboDescuento = new ComboBox();
            lblTickets = new Label();
            btnTicket = new Button();
            btnGuardar = new Button();
            cboTicket = new ComboBox();
            lblDescuento = new Label();
            cbxDescuento = new CheckBox();
            panel1 = new Panel();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(18, 171);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(151, 28);
            cboFormaPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.ForeColor = Color.LightGray;
            lblFormaPago.Location = new Point(18, 152);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(131, 16);
            lblFormaPago.TabIndex = 1;
            lblFormaPago.Text = "FORMA DE PAGO";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColSala, ColHorario, ColButaca, ColPrecio, ColAccion });
            dgvTickets.Location = new Point(272, 0);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(693, 362);
            dgvTickets.TabIndex = 2;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            // 
            // ColPelicula
            // 
            ColPelicula.HeaderText = "Pelicula";
            ColPelicula.MinimumWidth = 6;
            ColPelicula.Name = "ColPelicula";
            ColPelicula.ReadOnly = true;
            ColPelicula.Width = 125;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "Sala";
            ColSala.MinimumWidth = 6;
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            ColSala.Width = 125;
            // 
            // ColHorario
            // 
            ColHorario.HeaderText = "Inicio-Fin";
            ColHorario.MinimumWidth = 6;
            ColHorario.Name = "ColHorario";
            ColHorario.ReadOnly = true;
            ColHorario.Width = 125;
            // 
            // ColButaca
            // 
            ColButaca.HeaderText = "Butaca F-C";
            ColButaca.MinimumWidth = 6;
            ColButaca.Name = "ColButaca";
            ColButaca.ReadOnly = true;
            ColButaca.Width = 60;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "PRECIO";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 80;
            // 
            // ColAccion
            // 
            ColAccion.HeaderText = "Accion";
            ColAccion.MinimumWidth = 6;
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Resizable = DataGridViewTriState.True;
            ColAccion.SortMode = DataGridViewColumnSortMode.Automatic;
            ColAccion.Width = 125;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(367, 378);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0,00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.LightGray;
            lblTotal.Location = new Point(297, 384);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 16);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL :";
            // 
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.Enabled = false;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(18, 247);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(151, 28);
            cboDescuento.TabIndex = 6;
            cboDescuento.SelectedIndexChanged += cboDescuento_SelectedIndexChanged;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTickets.ForeColor = Color.FromArgb(229, 9, 20);
            lblTickets.Location = new Point(75, 20);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(119, 25);
            lblTickets.TabIndex = 7;
            lblTickets.Text = "TICKETS: ";
            // 
            // btnTicket
            // 
            btnTicket.FlatAppearance.BorderSize = 2;
            btnTicket.FlatStyle = FlatStyle.Flat;
            btnTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicket.ForeColor = Color.LightGray;
            btnTicket.Location = new Point(18, 64);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(227, 57);
            btnTicket.TabIndex = 8;
            btnTicket.Text = "NUEVO TICKET";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.LightGray;
            btnGuardar.Location = new Point(18, 314);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(227, 57);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboTicket
            // 
            cboTicket.Enabled = false;
            cboTicket.FormattingEnabled = true;
            cboTicket.Location = new Point(217, 171);
            cboTicket.Margin = new Padding(3, 4, 3, 4);
            cboTicket.Name = "cboTicket";
            cboTicket.Size = new Size(20, 28);
            cboTicket.TabIndex = 10;
            cboTicket.Visible = false;
            cboTicket.SelectedIndexChanged += cboTicket_SelectedIndexChanged;
            cboTicket.DataSourceChanged += cboTicket_DataSourceChanged;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.LightGray;
            lblDescuento.Location = new Point(217, 253);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(28, 16);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "0%";
            lblDescuento.Visible = false;
            lblDescuento.Click += lblDescuento_Click;
            // 
            // cbxDescuento
            // 
            cbxDescuento.AutoSize = true;
            cbxDescuento.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDescuento.ForeColor = Color.LightGray;
            cbxDescuento.Location = new Point(18, 221);
            cbxDescuento.Margin = new Padding(3, 4, 3, 4);
            cbxDescuento.Name = "cbxDescuento";
            cbxDescuento.Size = new Size(123, 20);
            cbxDescuento.TabIndex = 12;
            cbxDescuento.Text = "DESCUENTO";
            cbxDescuento.UseVisualStyleBackColor = true;
            cbxDescuento.CheckedChanged += cbxDescuento_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(btnTicket);
            panel1.Controls.Add(lblTickets);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(cboTicket);
            panel1.Controls.Add(cbxDescuento);
            panel1.Controls.Add(lblDescuento);
            panel1.Controls.Add(cboFormaPago);
            panel1.Controls.Add(lblFormaPago);
            panel1.Controls.Add(cboDescuento);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 423);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(836, 372);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(107, 38);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(965, 423);
            Controls.Add(btnSalir);
            Controls.Add(panel1);
            Controls.Add(lblTotal);
            Controls.Add(txtTotal);
            Controls.Add(dgvTickets);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComprobante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Comprobante";
            Load += FrmComprobante_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboFormaPago;
        private Label lblFormaPago;
        private TextBox txtTotal;
        private Label lblTotal;
        private ComboBox cboDescuento;
        private Label lblTickets;
        private Button btnTicket;
        private Button btnGuardar;
        public DataGridView dgvTickets;
        public ComboBox cboTicket;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColHorario;
        private DataGridViewTextBoxColumn ColButaca;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAccion;
        private Label lblDescuento;
        private CheckBox cbxDescuento;
        private Panel panel1;
        private Button btnSalir;
    }
}
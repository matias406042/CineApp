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
            comboBox1 = new ComboBox();
            lblFormaPago = new Label();
            dgvTickets = new DataGridView();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColHorario = new DataGridViewTextBoxColumn();
            ColButaca = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColAccion = new DataGridViewButtonColumn();
            txbTotal = new TextBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            comboBox2 = new ComboBox();
            lblTickets = new Label();
            btnTicket = new Button();
            btnGuardar = new Button();
            cboTicket = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(686, 58);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(686, 40);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(87, 15);
            lblFormaPago.TabIndex = 1;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColSala, ColHorario, ColButaca, ColPrecio, ColAccion });
            dgvTickets.Location = new Point(10, 58);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(661, 190);
            dgvTickets.TabIndex = 2;
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
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Resizable = DataGridViewTriState.True;
            ColAccion.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txbTotal
            // 
            txbTotal.Location = new Point(561, 273);
            txbTotal.Margin = new Padding(3, 2, 3, 2);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(110, 23);
            txbTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(504, 275);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(45, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(686, 160);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(63, 15);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(686, 178);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 6;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(10, 33);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(49, 15);
            lblTickets.TabIndex = 7;
            lblTickets.Text = "Tickets :";
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(589, 32);
            btnTicket.Margin = new Padding(3, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(82, 22);
            btnTicket.TabIndex = 8;
            btnTicket.Text = "New Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 307);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 22);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboTicket
            // 
            cboTicket.Enabled = false;
            cboTicket.FormattingEnabled = true;
            cboTicket.Location = new Point(828, 303);
            cboTicket.Name = "cboTicket";
            cboTicket.Size = new Size(18, 23);
            cboTicket.TabIndex = 10;
            cboTicket.Visible = false;
            cboTicket.SelectedIndexChanged += cboTicket_SelectedIndexChanged;
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 338);
            Controls.Add(cboTicket);
            Controls.Add(btnGuardar);
            Controls.Add(btnTicket);
            Controls.Add(lblTickets);
            Controls.Add(comboBox2);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotal);
            Controls.Add(txbTotal);
            Controls.Add(dgvTickets);
            Controls.Add(lblFormaPago);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmComprobante";
            Text = "Nuevo Comprobante";
            Load += FrmComprobante_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblFormaPago;
        private TextBox txbTotal;
        private Label lblTotal;
        private Label lblDescuento;
        private ComboBox comboBox2;
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
    }
}
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
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(686, 58);
            cboFormaPago.Margin = new Padding(3, 2, 3, 2);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(133, 23);
            cboFormaPago.TabIndex = 0;
            cboFormaPago.SelectedIndexChanged += cboFormaPago_SelectedIndexChanged;
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
            ColAccion.Name = "ColAccion";
            ColAccion.ReadOnly = true;
            ColAccion.Resizable = DataGridViewTriState.True;
            ColAccion.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(561, 273);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0";
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
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.Enabled = false;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(686, 150);
            cboDescuento.Margin = new Padding(3, 2, 3, 2);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(133, 23);
            cboDescuento.TabIndex = 6;
            cboDescuento.SelectedIndexChanged += cboDescuento_SelectedIndexChanged;
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
            cboTicket.DataSourceChanged += cboTicket_DataSourceChanged;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(729, 192);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(37, 25);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "0%";
            lblDescuento.Visible = false;
            lblDescuento.Click += lblDescuento_Click;
            // 
            // cbxDescuento
            // 
            cbxDescuento.AutoSize = true;
            cbxDescuento.Location = new Point(690, 126);
            cbxDescuento.Name = "cbxDescuento";
            cbxDescuento.Size = new Size(82, 19);
            cbxDescuento.TabIndex = 12;
            cbxDescuento.Text = "Descuento";
            cbxDescuento.UseVisualStyleBackColor = true;
            cbxDescuento.CheckedChanged += cbxDescuento_CheckedChanged;
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 338);
            Controls.Add(cbxDescuento);
            Controls.Add(cboDescuento);
            Controls.Add(txtTotal);
            Controls.Add(cboFormaPago);
            Controls.Add(cboTicket);
            Controls.Add(btnGuardar);
            Controls.Add(btnTicket);
            Controls.Add(lblTickets);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotal);
            Controls.Add(dgvTickets);
            Controls.Add(lblFormaPago);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmComprobante";
            Text = "Nuevo Comprobante";
            Load += FrmComprobante_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
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
    }
}
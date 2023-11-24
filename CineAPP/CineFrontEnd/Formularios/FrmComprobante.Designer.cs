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
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(12, 299);
            cboFormaPago.Margin = new Padding(3, 2, 3, 2);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(133, 23);
            cboFormaPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.ForeColor = Color.LightGray;
            lblFormaPago.Location = new Point(12, 275);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(89, 15);
            lblFormaPago.TabIndex = 1;
            lblFormaPago.Text = "Forma de Pago";
            lblFormaPago.Click += lblFormaPago_Click;
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColSala, ColHorario, ColButaca, ColPrecio, ColAccion });
            dgvTickets.Location = new Point(12, 55);
            dgvTickets.Margin = new Padding(3, 2, 3, 2);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(623, 190);
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
            ColSala.Width = 80;
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
            txtTotal.Location = new Point(458, 273);
            txtTotal.Margin = new Padding(3, 2, 3, 2);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(110, 23);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.LightGray;
            lblTotal.Location = new Point(401, 275);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(49, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL :";
            // 
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.Enabled = false;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(175, 299);
            cboDescuento.Margin = new Padding(3, 2, 3, 2);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(133, 23);
            cboDescuento.TabIndex = 6;
            cboDescuento.SelectedIndexChanged += cboDescuento_SelectedIndexChanged;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTickets.ForeColor = Color.LightGray;
            lblTickets.Location = new Point(10, 33);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(53, 15);
            lblTickets.TabIndex = 7;
            lblTickets.Text = "Tickets :";
            // 
            // btnTicket
            // 
            btnTicket.BackColor = Color.FromArgb(64, 64, 64);
            btnTicket.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnTicket.FlatAppearance.BorderSize = 3;
            btnTicket.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnTicket.FlatStyle = FlatStyle.Flat;
            btnTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTicket.ForeColor = Color.LightGray;
            btnTicket.Location = new Point(299, 20);
            btnTicket.Margin = new Padding(3, 2, 3, 2);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(82, 28);
            btnTicket.TabIndex = 8;
            btnTicket.Text = "New Ticket";
            btnTicket.UseVisualStyleBackColor = false;
            btnTicket.Click += btnTicket_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(64, 64, 64);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnGuardar.FlatAppearance.BorderSize = 3;
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.LightGray;
            btnGuardar.Location = new Point(401, 326);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(124, 35);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboTicket
            // 
            cboTicket.Enabled = false;
            cboTicket.FormattingEnabled = true;
            cboTicket.Location = new Point(668, 12);
            cboTicket.Name = "cboTicket";
            cboTicket.Size = new Size(18, 23);
            cboTicket.TabIndex = 10;
            cboTicket.Visible = false;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.LightGray;
            lblDescuento.Location = new Point(224, 336);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(38, 25);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "0%";
            lblDescuento.Visible = false;
            // 
            // cbxDescuento
            // 
            cbxDescuento.AutoSize = true;
            cbxDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDescuento.ForeColor = Color.LightGray;
            cbxDescuento.Location = new Point(179, 275);
            cbxDescuento.Name = "cbxDescuento";
            cbxDescuento.Size = new Size(86, 19);
            cbxDescuento.TabIndex = 12;
            cbxDescuento.Text = "Descuento";
            cbxDescuento.UseVisualStyleBackColor = true;
            cbxDescuento.CheckedChanged += cbxDescuento_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(64, 64, 64);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(561, 326);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 35);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(698, 381);
            Controls.Add(btnCancelar);
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
            ForeColor = Color.FromArgb(15, 15, 15);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmComprobante";
            Text = "Nuevo Comprobante";
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
        private Label lblDescuento;
        private CheckBox cbxDescuento;
        private Button btnCancelar;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColHorario;
        private DataGridViewTextBoxColumn ColButaca;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewButtonColumn ColAccion;
    }
}
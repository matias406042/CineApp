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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            SuspendLayout();
            // 
            // cboFormaPago
            // 
            cboFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(14, 399);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(151, 28);
            cboFormaPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.ForeColor = Color.LightGray;
            lblFormaPago.Location = new Point(29, 367);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(114, 20);
            lblFormaPago.TabIndex = 1;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.AllowUserToDeleteRows = false;
            dgvTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTickets.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColSala, ColHorario, ColButaca, ColPrecio, ColAccion });
            dgvTickets.Location = new Point(14, 73);
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.RowTemplate.Height = 29;
            dgvTickets.Size = new Size(647, 253);
            dgvTickets.TabIndex = 2;
            dgvTickets.CellContentClick += dgvTickets_CellContentClick;
            dgvTickets.RowsAdded += dgvTickets_RowsAdded;
            dgvTickets.RowsRemoved += dgvTickets_RowsRemoved;
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
            txtTotal.Location = new Point(523, 364);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 3;
            txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.LightGray;
            lblTotal.Location = new Point(458, 367);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(62, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL :";
            // 
            // cboDescuento
            // 
            cboDescuento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDescuento.FormattingEnabled = true;
            cboDescuento.Location = new Point(200, 399);
            cboDescuento.Name = "cboDescuento";
            cboDescuento.Size = new Size(151, 28);
            cboDescuento.TabIndex = 6;
            cboDescuento.SelectedIndexChanged += cboDescuento_SelectedIndexChanged;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTickets.ForeColor = Color.LightGray;
            lblTickets.Location = new Point(11, 44);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(66, 20);
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
            btnTicket.Location = new Point(567, 30);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(94, 37);
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
            btnGuardar.Location = new Point(458, 435);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 47);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cboTicket
            // 
            cboTicket.Enabled = false;
            cboTicket.FormattingEnabled = true;
            cboTicket.Location = new Point(763, 16);
            cboTicket.Margin = new Padding(3, 4, 3, 4);
            cboTicket.Name = "cboTicket";
            cboTicket.Size = new Size(20, 28);
            cboTicket.TabIndex = 10;
            cboTicket.Visible = false;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescuento.ForeColor = Color.LightGray;
            lblDescuento.Location = new Point(256, 448);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(45, 30);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "0%";
            lblDescuento.Visible = false;
            // 
            // cbxDescuento
            // 
            cbxDescuento.AutoSize = true;
            cbxDescuento.Checked = true;
            cbxDescuento.CheckState = CheckState.Checked;
            cbxDescuento.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxDescuento.ForeColor = Color.LightGray;
            cbxDescuento.Location = new Point(223, 333);
            cbxDescuento.Margin = new Padding(3, 4, 3, 4);
            cbxDescuento.Name = "cbxDescuento";
            cbxDescuento.Size = new Size(105, 24);
            cbxDescuento.TabIndex = 12;
            cbxDescuento.Text = "Descuento";
            cbxDescuento.UseVisualStyleBackColor = true;
            cbxDescuento.Visible = false;
            cbxDescuento.CheckedChanged += cbxDescuento_CheckedChanged_1;
            cbxDescuento.Click += cbxDescuento_CheckedChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(50, 0, 0);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0);
            btnCancelar.FlatAppearance.BorderSize = 3;
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.LightGray;
            btnCancelar.Location = new Point(643, 435);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 47);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(235, 367);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 14;
            label1.Text = "Descuento";
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(798, 508);
            Controls.Add(label1);
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
        private Label label1;
    }
}
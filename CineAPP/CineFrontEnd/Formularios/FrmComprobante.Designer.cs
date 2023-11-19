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
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.lblFormaPago = new System.Windows.Forms.Label();
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.ColPelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColButaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboDescuento = new System.Windows.Forms.ComboBox();
            this.lblTickets = new System.Windows.Forms.Label();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboTicket = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.cbxDescuento = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(686, 58);
            this.cboFormaPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(133, 23);
            this.cboFormaPago.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            this.lblFormaPago.AutoSize = true;
            this.lblFormaPago.Location = new System.Drawing.Point(686, 40);
            this.lblFormaPago.Name = "lblFormaPago";
            this.lblFormaPago.Size = new System.Drawing.Size(87, 15);
            this.lblFormaPago.TabIndex = 1;
            this.lblFormaPago.Text = "Forma de Pago";
            // 
            // dgvTickets
            // 
            this.dgvTickets.AllowUserToAddRows = false;
            this.dgvTickets.AllowUserToDeleteRows = false;
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPelicula,
            this.ColSala,
            this.ColHorario,
            this.ColButaca,
            this.ColPrecio,
            this.ColAccion});
            this.dgvTickets.Location = new System.Drawing.Point(10, 58);
            this.dgvTickets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowHeadersWidth = 51;
            this.dgvTickets.RowTemplate.Height = 29;
            this.dgvTickets.Size = new System.Drawing.Size(661, 190);
            this.dgvTickets.TabIndex = 2;
            // 
            // ColPelicula
            // 
            this.ColPelicula.HeaderText = "Pelicula";
            this.ColPelicula.MinimumWidth = 6;
            this.ColPelicula.Name = "ColPelicula";
            this.ColPelicula.ReadOnly = true;
            this.ColPelicula.Width = 125;
            // 
            // ColSala
            // 
            this.ColSala.HeaderText = "Sala";
            this.ColSala.MinimumWidth = 6;
            this.ColSala.Name = "ColSala";
            this.ColSala.ReadOnly = true;
            this.ColSala.Width = 125;
            // 
            // ColHorario
            // 
            this.ColHorario.HeaderText = "Inicio-Fin";
            this.ColHorario.MinimumWidth = 6;
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            this.ColHorario.Width = 125;
            // 
            // ColButaca
            // 
            this.ColButaca.HeaderText = "Butaca F-C";
            this.ColButaca.MinimumWidth = 6;
            this.ColButaca.Name = "ColButaca";
            this.ColButaca.ReadOnly = true;
            this.ColButaca.Width = 60;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "PRECIO";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 80;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(561, 273);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(110, 23);
            this.txtTotal.TabIndex = 3;
            this.txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(504, 275);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 15);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "TOTAL :";
            // 
            // cboDescuento
            // 
            this.cboDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDescuento.Enabled = false;
            this.cboDescuento.FormattingEnabled = true;
            this.cboDescuento.Location = new System.Drawing.Point(686, 150);
            this.cboDescuento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDescuento.Name = "cboDescuento";
            this.cboDescuento.Size = new System.Drawing.Size(133, 23);
            this.cboDescuento.TabIndex = 6;
            this.cboDescuento.SelectedIndexChanged += new System.EventHandler(this.cboDescuento_SelectedIndexChanged);
            // 
            // lblTickets
            // 
            this.lblTickets.AutoSize = true;
            this.lblTickets.Location = new System.Drawing.Point(10, 33);
            this.lblTickets.Name = "lblTickets";
            this.lblTickets.Size = new System.Drawing.Size(49, 15);
            this.lblTickets.TabIndex = 7;
            this.lblTickets.Text = "Tickets :";
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(589, 32);
            this.btnTicket.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(82, 22);
            this.btnTicket.TabIndex = 8;
            this.btnTicket.Text = "New Ticket";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(10, 307);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 22);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboTicket
            // 
            this.cboTicket.Enabled = false;
            this.cboTicket.FormattingEnabled = true;
            this.cboTicket.Location = new System.Drawing.Point(828, 303);
            this.cboTicket.Name = "cboTicket";
            this.cboTicket.Size = new System.Drawing.Size(18, 23);
            this.cboTicket.TabIndex = 10;
            this.cboTicket.Visible = false;
            this.cboTicket.SelectedIndexChanged += new System.EventHandler(this.cboTicket_SelectedIndexChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescuento.Location = new System.Drawing.Point(729, 192);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(37, 25);
            this.lblDescuento.TabIndex = 11;
            this.lblDescuento.Text = "0%";
            this.lblDescuento.Visible = false;
            // 
            // cbxDescuento
            // 
            this.cbxDescuento.AutoSize = true;
            this.cbxDescuento.Location = new System.Drawing.Point(690, 126);
            this.cbxDescuento.Name = "cbxDescuento";
            this.cbxDescuento.Size = new System.Drawing.Size(82, 19);
            this.cbxDescuento.TabIndex = 12;
            this.cbxDescuento.Text = "Descuento";
            this.cbxDescuento.UseVisualStyleBackColor = true;
            this.cbxDescuento.CheckedChanged += new System.EventHandler(this.cbxDescuento_CheckedChanged);
            // 
            // FrmComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 338);
            this.Controls.Add(this.cbxDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.cboTicket);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.lblTickets);
            this.Controls.Add(this.cboDescuento);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.lblFormaPago);
            this.Controls.Add(this.cboFormaPago);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmComprobante";
            this.Text = "Nuevo Comprobante";
            this.Load += new System.EventHandler(this.FrmComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
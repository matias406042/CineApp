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
            dataGridView1 = new DataGridView();
            txbTotal = new TextBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            comboBox2 = new ComboBox();
            lblTickets = new Label();
            btnTicket = new Button();
            btnGuardar = new Button();
            ColPelicula = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColHorario = new DataGridViewTextBoxColumn();
            ColButaca = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(603, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(603, 54);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(109, 20);
            lblFormaPago.TabIndex = 1;
            lblFormaPago.Text = "Forma de Pago";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPelicula, ColSala, ColHorario, ColButaca, ColPrecio });
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(576, 254);
            dataGridView1.TabIndex = 2;
            // 
            // txbTotal
            // 
            txbTotal.Location = new Point(463, 349);
            txbTotal.Name = "txbTotal";
            txbTotal.Size = new Size(125, 27);
            txbTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(398, 352);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(57, 20);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "TOTAL :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(603, 214);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(79, 20);
            lblDescuento.TabIndex = 5;
            lblDescuento.Text = "Descuento";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(603, 237);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 6;
            // 
            // lblTickets
            // 
            lblTickets.AutoSize = true;
            lblTickets.Location = new Point(12, 44);
            lblTickets.Name = "lblTickets";
            lblTickets.Size = new Size(61, 20);
            lblTickets.TabIndex = 7;
            lblTickets.Text = "Tickets :";
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(494, 45);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(94, 29);
            btnTicket.TabIndex = 8;
            btnTicket.Text = "New Ticket";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 409);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(142, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnSave_Click;
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
            ColButaca.Width = 125;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "PRECIO";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 125;
            // 
            // FrmComprobante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnTicket);
            Controls.Add(lblTickets);
            Controls.Add(comboBox2);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotal);
            Controls.Add(txbTotal);
            Controls.Add(dataGridView1);
            Controls.Add(lblFormaPago);
            Controls.Add(comboBox1);
            Name = "FrmComprobante";
            Text = "Nuevo Comprobante";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblFormaPago;
        private DataGridView dataGridView1;
        private TextBox txbTotal;
        private Label lblTotal;
        private Label lblDescuento;
        private ComboBox comboBox2;
        private Label lblTickets;
        private Button btnTicket;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn ColPelicula;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColHorario;
        private DataGridViewTextBoxColumn ColButaca;
        private DataGridViewTextBoxColumn ColPrecio;
    }
}
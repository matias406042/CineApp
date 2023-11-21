namespace CineFrontEnd.Formularios
{
    partial class FrmTicket
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
            dgvFunciones = new DataGridView();
            ColFuncionID = new DataGridViewTextBoxColumn();
            ColPElicula = new DataGridViewTextBoxColumn();
            Colhorario = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColDIMENSION = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColACCION = new DataGridViewCheckBoxColumn();
            btnSearch = new Button();
            dtpFecha = new DateTimePicker();
            txbTitulo = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            cbxTitulo = new CheckBox();
            cbxFecha = new CheckBox();
            btnButacas = new Button();
            txtButaca = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColFuncionID, ColPElicula, Colhorario, Column1, ColSala, ColDIMENSION, ColPrecio, ColACCION });
            dgvFunciones.Location = new Point(287, 0);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(928, 478);
            dgvFunciones.TabIndex = 0;
            dgvFunciones.CellContentClick += dgvFunciones_CellContentClick;
            // 
            // ColFuncionID
            // 
            ColFuncionID.HeaderText = "ID";
            ColFuncionID.MinimumWidth = 6;
            ColFuncionID.Name = "ColFuncionID";
            ColFuncionID.ReadOnly = true;
            ColFuncionID.Visible = false;
            ColFuncionID.Width = 125;
            // 
            // ColPElicula
            // 
            ColPElicula.HeaderText = "PELICULA";
            ColPElicula.MinimumWidth = 6;
            ColPElicula.Name = "ColPElicula";
            ColPElicula.ReadOnly = true;
            ColPElicula.Width = 125;
            // 
            // Colhorario
            // 
            Colhorario.HeaderText = "HORARIO INICIO";
            Colhorario.MinimumWidth = 6;
            Colhorario.Name = "Colhorario";
            Colhorario.ReadOnly = true;
            Colhorario.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "HORARIO FIN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "SALA";
            ColSala.MinimumWidth = 6;
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            ColSala.Width = 125;
            // 
            // ColDIMENSION
            // 
            ColDIMENSION.HeaderText = "DIMENSION";
            ColDIMENSION.MinimumWidth = 6;
            ColDIMENSION.Name = "ColDIMENSION";
            ColDIMENSION.ReadOnly = true;
            ColDIMENSION.Width = 125;
            // 
            // ColPrecio
            // 
            ColPrecio.HeaderText = "PRECIO";
            ColPrecio.MinimumWidth = 6;
            ColPrecio.Name = "ColPrecio";
            ColPrecio.ReadOnly = true;
            ColPrecio.Width = 125;
            // 
            // ColACCION
            // 
            ColACCION.HeaderText = "ACCION";
            ColACCION.MinimumWidth = 6;
            ColACCION.Name = "ColACCION";
            ColACCION.ReadOnly = true;
            ColACCION.Resizable = DataGridViewTriState.True;
            ColACCION.SortMode = DataGridViewColumnSortMode.Automatic;
            ColACCION.Width = 125;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderColor = Color.LightGray;
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.LightGray;
            btnSearch.Location = new Point(24, 492);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 36);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Enabled = false;
            dtpFecha.Location = new Point(24, 195);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(165, 27);
            dtpFecha.TabIndex = 4;
            // 
            // txbTitulo
            // 
            txbTitulo.Enabled = false;
            txbTitulo.Location = new Point(24, 108);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(165, 27);
            txbTitulo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 9, 20);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(257, 28);
            label1.TabIndex = 8;
            label1.Text = "BUSQUEDA DE FUNCION :";
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderColor = Color.LightGray;
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.LightGray;
            btnSave.Location = new Point(166, 492);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(103, 36);
            btnSave.TabIndex = 9;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnClose.FlatAppearance.BorderSize = 4;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.LightGray;
            btnClose.Location = new Point(1090, 492);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 36);
            btnClose.TabIndex = 10;
            btnClose.Text = "SALIR";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_1;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxTitulo.ForeColor = Color.LightGray;
            cbxTitulo.Location = new Point(24, 76);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(84, 24);
            cbxTitulo.TabIndex = 11;
            cbxTitulo.Text = "TITULO";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged_1;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxFecha.ForeColor = Color.LightGray;
            cbxFecha.Location = new Point(24, 164);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(78, 24);
            cbxFecha.TabIndex = 12;
            cbxFecha.Text = "FECHA";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.CheckedChanged += cbxFecha_CheckedChanged_1;
            // 
            // btnButacas
            // 
            btnButacas.Enabled = false;
            btnButacas.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnButacas.FlatAppearance.BorderSize = 8;
            btnButacas.FlatStyle = FlatStyle.Flat;
            btnButacas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacas.ForeColor = Color.LightGray;
            btnButacas.Location = new Point(24, 276);
            btnButacas.Margin = new Padding(3, 4, 3, 4);
            btnButacas.Name = "btnButacas";
            btnButacas.Size = new Size(217, 81);
            btnButacas.TabIndex = 13;
            btnButacas.Text = "ELEGIR BUTACA";
            btnButacas.UseVisualStyleBackColor = true;
            btnButacas.Click += btnButacas_Click;
            // 
            // txtButaca
            // 
            txtButaca.Enabled = false;
            txtButaca.Location = new Point(189, 414);
            txtButaca.Margin = new Padding(3, 4, 3, 4);
            txtButaca.Name = "txtButaca";
            txtButaca.Size = new Size(81, 27);
            txtButaca.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(229, 9, 20);
            label2.Location = new Point(24, 395);
            label2.Name = "label2";
            label2.Size = new Size(136, 46);
            label2.TabIndex = 15;
            label2.Text = "BUTACA\r\nSELECCIONADA";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(cbxTitulo);
            panel1.Controls.Add(btnButacas);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(txtButaca);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txbTitulo);
            panel1.Controls.Add(cbxFecha);
            panel1.Controls.Add(dtpFecha);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 540);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // FrmTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1216, 540);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(dgvFunciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFunciones;
        private Button btnSearch;
        private DateTimePicker dtpFecha;
        private TextBox txbTitulo;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private CheckBox cbxTitulo;
        private CheckBox cbxFecha;
        private Button btnButacas;
        public TextBox txtButaca;
        private Label label2;
        private DataGridViewTextBoxColumn ColFuncionID;
        private DataGridViewTextBoxColumn ColPElicula;
        private DataGridViewTextBoxColumn Colhorario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColDIMENSION;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewCheckBoxColumn ColACCION;
        private Panel panel1;
    }
}
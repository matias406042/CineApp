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
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { ColFuncionID, ColPElicula, Colhorario, Column1, ColSala, ColDIMENSION, ColPrecio, ColACCION });
            dgvFunciones.Location = new Point(14, 152);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(676, 239);
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
            ColFuncionID.Width = 6;
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
            Colhorario.HeaderText = "INICIO";
            Colhorario.MinimumWidth = 6;
            Colhorario.Name = "Colhorario";
            Colhorario.ReadOnly = true;
            Colhorario.Width = 71;
            // 
            // Column1
            // 
            Column1.HeaderText = "FIN";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 75;
            // 
            // ColSala
            // 
            ColSala.HeaderText = "SALA";
            ColSala.MinimumWidth = 6;
            ColSala.Name = "ColSala";
            ColSala.ReadOnly = true;
            ColSala.Width = 75;
            // 
            // ColDIMENSION
            // 
            ColDIMENSION.HeaderText = "TIPO";
            ColDIMENSION.MinimumWidth = 6;
            ColDIMENSION.Name = "ColDIMENSION";
            ColDIMENSION.ReadOnly = true;
            ColDIMENSION.Width = 75;
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
            ColACCION.Width = 75;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(64, 64, 64);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnSearch.FlatAppearance.BorderSize = 3;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.LightGray;
            btnSearch.Location = new Point(596, 70);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 34);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "BUSCAR";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(422, 72);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(165, 27);
            dtpFecha.TabIndex = 4;
            // 
            // txbTitulo
            // 
            txbTitulo.Enabled = false;
            txbTitulo.Location = new Point(233, 72);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(142, 27);
            txbTitulo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(14, 28);
            label1.Name = "label1";
            label1.Size = new Size(181, 70);
            label1.TabIndex = 8;
            label1.Text = "BUSQUEDA \r\nDE FUNCION :";
            label1.Click += label1_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(64, 64, 64);
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnSave.FlatAppearance.BorderSize = 3;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = Color.LightGray;
            btnSave.Location = new Point(556, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(99, 46);
            btnSave.TabIndex = 9;
            btnSave.Text = "GUARDAR";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(50, 0, 0);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0);
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.LightGray;
            btnClose.Location = new Point(701, 432);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(83, 46);
            btnClose.TabIndex = 10;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxTitulo.ForeColor = Color.LightGray;
            cbxTitulo.Location = new Point(233, 41);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(72, 24);
            cbxTitulo.TabIndex = 11;
            cbxTitulo.Text = "Titulo";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged_1;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Enabled = false;
            cbxFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxFecha.ForeColor = Color.LightGray;
            cbxFecha.Location = new Point(422, 41);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(71, 24);
            cbxFecha.TabIndex = 12;
            cbxFecha.Text = "Fecha";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.Visible = false;
            // 
            // btnButacas
            // 
            btnButacas.BackColor = Color.FromArgb(64, 64, 64);
            btnButacas.Enabled = false;
            btnButacas.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnButacas.FlatAppearance.BorderSize = 3;
            btnButacas.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnButacas.FlatStyle = FlatStyle.Flat;
            btnButacas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnButacas.ForeColor = Color.LightGray;
            btnButacas.Location = new Point(267, 409);
            btnButacas.Margin = new Padding(3, 4, 3, 4);
            btnButacas.Name = "btnButacas";
            btnButacas.Size = new Size(127, 69);
            btnButacas.TabIndex = 13;
            btnButacas.Text = "ELEGIR BUTACA";
            btnButacas.UseVisualStyleBackColor = false;
            btnButacas.Click += btnButacas_Click;
            // 
            // txtButaca
            // 
            txtButaca.Enabled = false;
            txtButaca.Location = new Point(57, 448);
            txtButaca.Margin = new Padding(3, 4, 3, 4);
            txtButaca.Name = "txtButaca";
            txtButaca.Size = new Size(204, 27);
            txtButaca.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(57, 409);
            label2.Name = "label2";
            label2.Size = new Size(204, 28);
            label2.TabIndex = 15;
            label2.Text = "Butaca seleccionada";
            label2.Click += label2_Click;
            // 
            // FrmTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(798, 502);
            Controls.Add(label2);
            Controls.Add(txtButaca);
            Controls.Add(btnButacas);
            Controls.Add(cbxFecha);
            Controls.Add(cbxTitulo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txbTitulo);
            Controls.Add(dtpFecha);
            Controls.Add(btnSearch);
            Controls.Add(dgvFunciones);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmTicket";
            Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}
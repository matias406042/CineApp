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
            dataGridView1 = new DataGridView();
            ColPElicula = new DataGridViewTextBoxColumn();
            Colhorario = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ColSala = new DataGridViewTextBoxColumn();
            ColDIMENSION = new DataGridViewTextBoxColumn();
            ColPrecio = new DataGridViewTextBoxColumn();
            ColACCION = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            cmbButacas = new ComboBox();
            lblButacas = new Label();
            dtpFecha = new DateTimePicker();
            txbTitulo = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            btnClose = new Button();
            cbxTitulo = new CheckBox();
            cbxFecha = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColPElicula, Colhorario, Column1, ColSala, ColDIMENSION, ColPrecio, ColACCION });
            dataGridView1.Location = new Point(12, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(536, 239);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
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
            ColPrecio.HeaderText = "Precio";
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
            ColACCION.Width = 125;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(454, 114);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // cmbButacas
            // 
            cmbButacas.FormattingEnabled = true;
            cmbButacas.Location = new Point(602, 42);
            cmbButacas.Name = "cmbButacas";
            cmbButacas.Size = new Size(165, 28);
            cmbButacas.TabIndex = 2;
            cmbButacas.SelectedIndexChanged += cmbButacas_SelectedIndexChanged;
            // 
            // lblButacas
            // 
            lblButacas.AutoSize = true;
            lblButacas.Location = new Point(602, 19);
            lblButacas.Name = "lblButacas";
            lblButacas.Size = new Size(165, 20);
            lblButacas.TabIndex = 3;
            lblButacas.Text = "BUTACAS DISPONIBLES";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(224, 116);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(165, 27);
            dtpFecha.TabIndex = 4;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(35, 116);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(142, 27);
            txbTitulo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 8;
            label1.Text = "BUSQUEDA DE FUNCION :";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(692, 409);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Location = new Point(35, 86);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(69, 24);
            cbxTitulo.TabIndex = 11;
            cbxTitulo.Text = "Titulo";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Location = new Point(224, 86);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(69, 24);
            cbxFecha.TabIndex = 12;
            cbxFecha.Text = "Fecha";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.CheckedChanged += cbxFecha_CheckedChanged;
            // 
            // FrmTicket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(cbxFecha);
            Controls.Add(cbxTitulo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txbTitulo);
            Controls.Add(dtpFecha);
            Controls.Add(lblButacas);
            Controls.Add(cmbButacas);
            Controls.Add(btnSearch);
            Controls.Add(dataGridView1);
            Name = "FrmTicket";
            Text = "Ticket";
            Load += FrmTicket_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColPElicula;
        private DataGridViewTextBoxColumn Colhorario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColDIMENSION;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewTextBoxColumn ColACCION;
        private Button btnSearch;
        private ComboBox cmbButacas;
        private Label lblButacas;
        private DateTimePicker dtpFecha;
        private TextBox txbTitulo;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private CheckBox cbxTitulo;
        private CheckBox cbxFecha;
    }
}
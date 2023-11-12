namespace CineFrontEnd.Formularios
{
    partial class FrmPeliculasSeleccionar
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
            dgvPelicula = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSerch = new Button();
            cbxTitulo = new CheckBox();
            cbxGenero = new CheckBox();
            cbxFecha = new CheckBox();
            txbTitulo = new TextBox();
            dtpEstreno = new DateTimePicker();
            groupBox1 = new GroupBox();
            cmbGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPelicula
            // 
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPelicula.Location = new Point(312, 12);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.RowHeadersWidth = 51;
            dgvPelicula.RowTemplate.Height = 29;
            dgvPelicula.Size = new Size(476, 426);
            dgvPelicula.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "TITULO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "GENERO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "FECHA ESTRENO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(25, 291);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(181, 394);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(181, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(25, 394);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSerch
            // 
            btnSerch.Location = new Point(13, 185);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(94, 29);
            btnSerch.TabIndex = 0;
            btnSerch.Text = "Search";
            btnSerch.UseVisualStyleBackColor = true;
            btnSerch.Click += btnSerch_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Location = new Point(13, 26);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(69, 24);
            cbxTitulo.TabIndex = 1;
            cbxTitulo.Text = "Titulo";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged;
            // 
            // cbxGenero
            // 
            cbxGenero.AutoSize = true;
            cbxGenero.Location = new Point(13, 71);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(79, 24);
            cbxGenero.TabIndex = 2;
            cbxGenero.Text = "Genero";
            cbxGenero.UseVisualStyleBackColor = true;
            cbxGenero.CheckedChanged += cbxGenero_CheckedChanged;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Location = new Point(13, 119);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(111, 24);
            cbxFecha.TabIndex = 3;
            cbxFecha.Text = "Año Estreno";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.CheckedChanged += cbxFecha_CheckedChanged;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(139, 23);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(125, 27);
            txbTitulo.TabIndex = 5;
            // 
            // dtpEstreno
            // 
            dtpEstreno.Format = DateTimePickerFormat.Custom;
            dtpEstreno.Location = new Point(139, 116);
            dtpEstreno.Name = "dtpEstreno";
            dtpEstreno.Size = new Size(110, 27);
            dtpEstreno.TabIndex = 7;
            dtpEstreno.ValueChanged += dtpFechaEstreno_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(dtpEstreno);
            groupBox1.Controls.Add(txbTitulo);
            groupBox1.Controls.Add(cbxFecha);
            groupBox1.Controls.Add(cbxGenero);
            groupBox1.Controls.Add(cbxTitulo);
            groupBox1.Controls.Add(btnSerch);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 240);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(139, 69);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(125, 28);
            cmbGenero.TabIndex = 8;
            // 
            // FrmPeliculasSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(dgvPelicula);
            Name = "FrmPeliculasSeleccionar";
            Text = "Seleccion de Peliculas";
            Load += FrmPeliculasSeleccionar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvPelicula;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSerch;
        private CheckBox cbxTitulo;
        private CheckBox cbxGenero;
        private CheckBox cbxFecha;
        private TextBox txbTitulo;
        private DateTimePicker dtpEstreno;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbGenero;
    }
}
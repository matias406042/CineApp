﻿namespace CineFrontEnd.Formularios
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
            groupBox1 = new GroupBox();
            txbAño = new TextBox();
            cmbGenero = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPelicula
            // 
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPelicula.Location = new Point(273, 9);
            dgvPelicula.Margin = new Padding(3, 2, 3, 2);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.RowHeadersWidth = 51;
            dgvPelicula.RowTemplate.Height = 29;
            dgvPelicula.Size = new Size(416, 320);
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
            btnUpdate.Location = new Point(22, 218);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(89, 22);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(145, 296);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(95, 22);
            btnClose.TabIndex = 9;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(145, 218);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(95, 22);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(22, 296);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(89, 22);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "AÑADIR NUEVO";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSerch
            // 
            btnSerch.Location = new Point(12, 139);
            btnSerch.Margin = new Padding(3, 2, 3, 2);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(218, 22);
            btnSerch.TabIndex = 0;
            btnSerch.Text = "Buscar";
            btnSerch.UseVisualStyleBackColor = true;
            btnSerch.Click += btnSerch_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Location = new Point(11, 20);
            cbxTitulo.Margin = new Padding(3, 2, 3, 2);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(56, 19);
            cbxTitulo.TabIndex = 1;
            cbxTitulo.Text = "Titulo";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged;
            // 
            // cbxGenero
            // 
            cbxGenero.AutoSize = true;
            cbxGenero.Location = new Point(11, 53);
            cbxGenero.Margin = new Padding(3, 2, 3, 2);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(64, 19);
            cbxGenero.TabIndex = 2;
            cbxGenero.Text = "Genero";
            cbxGenero.UseVisualStyleBackColor = true;
            cbxGenero.CheckedChanged += cbxGenero_CheckedChanged;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Location = new Point(11, 89);
            cbxFecha.Margin = new Padding(3, 2, 3, 2);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(90, 19);
            cbxFecha.TabIndex = 3;
            cbxFecha.Text = "Año Estreno";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.CheckedChanged += cbxFecha_CheckedChanged;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(122, 17);
            txbTitulo.Margin = new Padding(3, 2, 3, 2);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(110, 23);
            txbTitulo.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAño);
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(txbTitulo);
            groupBox1.Controls.Add(cbxFecha);
            groupBox1.Controls.Add(cbxGenero);
            groupBox1.Controls.Add(cbxTitulo);
            groupBox1.Controls.Add(btnSerch);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(247, 180);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txbAño
            // 
            txbAño.Location = new Point(122, 88);
            txbAño.Margin = new Padding(3, 2, 3, 2);
            txbAño.Name = "txbAño";
            txbAño.Size = new Size(110, 23);
            txbAño.TabIndex = 9;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(122, 52);
            cmbGenero.Margin = new Padding(3, 2, 3, 2);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(110, 23);
            cmbGenero.TabIndex = 8;
            // 
            // FrmPeliculasSeleccionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(dgvPelicula);
            Margin = new Padding(3, 2, 3, 2);
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
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbGenero;
        private TextBox txbAño;
    }
}
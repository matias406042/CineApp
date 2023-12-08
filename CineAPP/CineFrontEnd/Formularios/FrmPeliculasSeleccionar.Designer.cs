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
            cbxAñoEstreno = new CheckBox();
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
            dgvPelicula.AllowUserToAddRows = false;
            dgvPelicula.AllowUserToDeleteRows = false;
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPelicula.Location = new Point(335, 12);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.ReadOnly = true;
            dgvPelicula.RowHeadersWidth = 51;
            dgvPelicula.RowTemplate.Height = 29;
            dgvPelicula.Size = new Size(429, 427);
            dgvPelicula.TabIndex = 4;
            dgvPelicula.CellContentClick += dgvPelicula_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "TITULO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "GENERO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "FECHA ESTRENO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightGray;
            btnUpdate.Location = new Point(25, 291);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 29);
            btnUpdate.TabIndex = 0;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(50, 0, 0);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0);
            btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.LightGray;
            btnClose.Location = new Point(166, 395);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 29);
            btnClose.TabIndex = 9;
            btnClose.Text = "CERRAR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.LightGray;
            btnDelete.Location = new Point(166, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.LightGray;
            btnAdd.Location = new Point(25, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "AÑADIR NUEVO";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSerch
            // 
            btnSerch.BackColor = Color.FromArgb(64, 64, 64);
            btnSerch.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnSerch.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnSerch.FlatStyle = FlatStyle.Flat;
            btnSerch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerch.ForeColor = Color.LightGray;
            btnSerch.Location = new Point(14, 185);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(249, 29);
            btnSerch.TabIndex = 1;
            btnSerch.Text = "Buscar";
            btnSerch.UseVisualStyleBackColor = false;
            btnSerch.Click += btnSerch_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxTitulo.ForeColor = Color.LightGray;
            cbxTitulo.Location = new Point(13, 27);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(72, 24);
            cbxTitulo.TabIndex = 1;
            cbxTitulo.Text = "Titulo";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged;
            // 
            // cbxGenero
            // 
            cbxGenero.AutoSize = true;
            cbxGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxGenero.ForeColor = Color.LightGray;
            cbxGenero.Location = new Point(13, 71);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(82, 24);
            cbxGenero.TabIndex = 2;
            cbxGenero.Text = "Genero";
            cbxGenero.UseVisualStyleBackColor = true;
            cbxGenero.CheckedChanged += cbxGenero_CheckedChanged;
            // 
            // cbxAñoEstreno
            // 
            cbxAñoEstreno.AutoSize = true;
            cbxAñoEstreno.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxAñoEstreno.ForeColor = Color.LightGray;
            cbxAñoEstreno.Location = new Point(13, 119);
            cbxAñoEstreno.Name = "cbxAñoEstreno";
            cbxAñoEstreno.Size = new Size(117, 24);
            cbxAñoEstreno.TabIndex = 1;
            cbxAñoEstreno.Text = "Año Estreno";
            cbxAñoEstreno.UseVisualStyleBackColor = true;
            cbxAñoEstreno.CheckedChanged += cbxFecha_CheckedChanged;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(139, 23);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(125, 27);
            txbTitulo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txbAño);
            groupBox1.Controls.Add(cmbGenero);
            groupBox1.Controls.Add(txbTitulo);
            groupBox1.Controls.Add(cbxAñoEstreno);
            groupBox1.Controls.Add(cbxGenero);
            groupBox1.Controls.Add(cbxTitulo);
            groupBox1.Controls.Add(btnSerch);
            groupBox1.ForeColor = Color.LightGray;
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(282, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txbAño
            // 
            txbAño.Location = new Point(139, 117);
            txbAño.Name = "txbAño";
            txbAño.Size = new Size(125, 27);
            txbAño.TabIndex = 4;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(139, 69);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(125, 28);
            cmbGenero.TabIndex = 2;
            // 
            // FrmPeliculasSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(796, 508);
            Controls.Add(groupBox1);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(dgvPelicula);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
        private CheckBox cmbAñoEstreno;
        private TextBox txbTitulo;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbGenero;
        private TextBox txbAño;
        private CheckBox cbxAñoEstreno;
    }
}
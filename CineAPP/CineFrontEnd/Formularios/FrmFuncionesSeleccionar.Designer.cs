namespace CineFrontEnd.Formularios
{
    partial class FrmFuncionesSeleccionar
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
            btnBuscar = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dtpFecha = new DateTimePicker();
            btnExit = new Button();
            ColumnPelicula = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnHora = new DataGridViewTextBoxColumn();
            ColumnSala = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            dgvFunciones = new DataGridView();
            colIdFuncion = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colInicio = new DataGridViewTextBoxColumn();
            colFin = new DataGridViewTextBoxColumn();
            colSala = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.LightGray;
            btnBuscar.Location = new Point(0, 154);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(257, 61);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Bottom;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightGray;
            btnUpdate.Location = new Point(0, 275);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(257, 54);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.LightGray;
            btnDelete.Location = new Point(0, 329);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(257, 54);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(16, 101);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(119, 27);
            dtpFecha.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnExit.FlatAppearance.BorderSize = 4;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.LightGray;
            btnExit.Location = new Point(827, 329);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 40);
            btnExit.TabIndex = 5;
            btnExit.Text = "CLOSE";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ColumnPelicula
            // 
            ColumnPelicula.Frozen = true;
            ColumnPelicula.HeaderText = "Pelicula";
            ColumnPelicula.MinimumWidth = 6;
            ColumnPelicula.Name = "ColumnPelicula";
            ColumnPelicula.Width = 125;
            // 
            // ColumnFecha
            // 
            ColumnFecha.Frozen = true;
            ColumnFecha.HeaderText = "FECHA";
            ColumnFecha.MinimumWidth = 6;
            ColumnFecha.Name = "ColumnFecha";
            ColumnFecha.Width = 125;
            // 
            // ColumnHora
            // 
            ColumnHora.Frozen = true;
            ColumnHora.HeaderText = "Horario";
            ColumnHora.MinimumWidth = 6;
            ColumnHora.Name = "ColumnHora";
            ColumnHora.Width = 125;
            // 
            // ColumnSala
            // 
            ColumnSala.Frozen = true;
            ColumnSala.HeaderText = "SALA";
            ColumnSala.MinimumWidth = 6;
            ColumnSala.Name = "ColumnSala";
            ColumnSala.Width = 125;
            // 
            // ColumnTipo
            // 
            ColumnTipo.Frozen = true;
            ColumnTipo.HeaderText = "TIPO";
            ColumnTipo.MinimumWidth = 6;
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.Width = 125;
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { colIdFuncion, colTitulo, colGenero, colInicio, colFin, colSala });
            dgvFunciones.Location = new Point(254, 0);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(679, 309);
            dgvFunciones.TabIndex = 1;
            // 
            // colIdFuncion
            // 
            colIdFuncion.HeaderText = "ID";
            colIdFuncion.MinimumWidth = 6;
            colIdFuncion.Name = "colIdFuncion";
            colIdFuncion.ReadOnly = true;
            colIdFuncion.Visible = false;
            colIdFuncion.Width = 125;
            // 
            // colTitulo
            // 
            colTitulo.HeaderText = "Titulo";
            colTitulo.MinimumWidth = 6;
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            colTitulo.Width = 175;
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Genero";
            colGenero.MinimumWidth = 6;
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            colGenero.Width = 120;
            // 
            // colInicio
            // 
            colInicio.HeaderText = "Inicio";
            colInicio.MinimumWidth = 6;
            colInicio.Name = "colInicio";
            colInicio.ReadOnly = true;
            colInicio.Width = 120;
            // 
            // colFin
            // 
            colFin.HeaderText = "Fin";
            colFin.MinimumWidth = 6;
            colFin.Name = "colFin";
            colFin.ReadOnly = true;
            colFin.Width = 120;
            // 
            // colSala
            // 
            colSala.HeaderText = "Sala";
            colSala.MinimumWidth = 6;
            colSala.Name = "colSala";
            colSala.ReadOnly = true;
            colSala.Width = 90;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Bottom;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.LightGray;
            btnAdd.Location = new Point(0, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(257, 54);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(btnBuscar);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 383);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(229, 9, 20);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 8;
            label1.Text = "BUSQUEDA POR FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(16, 78);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 9;
            label2.Text = "FECHA";
            // 
            // FrmFuncionesSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(933, 383);
            Controls.Add(panel1);
            Controls.Add(btnExit);
            Controls.Add(dgvFunciones);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFuncionesSeleccionar";
            Text = "Funciones";
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnUpdate;
        private Button btnDelete;
        private DateTimePicker dtpFecha;
        private Button btnExit;
        private DataGridViewTextBoxColumn ColumnPelicula;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnHora;
        private DataGridViewTextBoxColumn ColumnSala;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridView dgvFunciones;
        private Button btnAdd;
        private DataGridViewTextBoxColumn colIdFuncion;
        private DataGridViewTextBoxColumn colTitulo;
        private DataGridViewTextBoxColumn colGenero;
        private DataGridViewTextBoxColumn colInicio;
        private DataGridViewTextBoxColumn colFin;
        private DataGridViewTextBoxColumn colSala;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
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
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(64, 64, 64);
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.LightGray;
            btnBuscar.Location = new Point(143, 10);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 33);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(64, 64, 64);
            btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnUpdate.FlatAppearance.BorderSize = 3;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.LightGray;
            btnUpdate.Location = new Point(12, 349);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 60);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(64, 64, 64);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatAppearance.BorderSize = 3;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.LightGray;
            btnDelete.Location = new Point(143, 349);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 60);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarMonthBackground = Color.FromArgb(40, 40, 40);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(12, 13);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(50, 0, 0);
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0);
            btnExit.FlatAppearance.BorderSize = 3;
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnExit.ForeColor = Color.LightGray;
            btnExit.Location = new Point(567, 349);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 60);
            btnExit.TabIndex = 5;
            btnExit.Text = "CERRAR";
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
            dgvFunciones.Location = new Point(12, 50);
            dgvFunciones.Margin = new Padding(3, 2, 3, 2);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(678, 259);
            dgvFunciones.TabIndex = 1;
            // 
            // colIdFuncion
            // 
            colIdFuncion.HeaderText = "ID";
            colIdFuncion.Name = "colIdFuncion";
            colIdFuncion.ReadOnly = true;
            colIdFuncion.Visible = false;
            // 
            // colTitulo
            // 
            colTitulo.HeaderText = "Titulo";
            colTitulo.Name = "colTitulo";
            colTitulo.ReadOnly = true;
            colTitulo.Width = 175;
            // 
            // colGenero
            // 
            colGenero.HeaderText = "Genero";
            colGenero.Name = "colGenero";
            colGenero.ReadOnly = true;
            colGenero.Width = 120;
            // 
            // colInicio
            // 
            colInicio.HeaderText = "Inicio";
            colInicio.Name = "colInicio";
            colInicio.ReadOnly = true;
            colInicio.Width = 120;
            // 
            // colFin
            // 
            colFin.HeaderText = "Fin";
            colFin.Name = "colFin";
            colFin.ReadOnly = true;
            colFin.Width = 120;
            // 
            // colSala
            // 
            colSala.HeaderText = "Sala";
            colSala.Name = "colSala";
            colSala.ReadOnly = true;
            colSala.Width = 90;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(64, 64, 64);
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatAppearance.BorderSize = 3;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.LightGray;
            btnAdd.Location = new Point(272, 349);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(123, 60);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "AÑADIR NUEVA";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // FrmFuncionesSeleccionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(714, 420);
            Controls.Add(btnExit);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFecha);
            Controls.Add(dgvFunciones);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFuncionesSeleccionar";
            Text = "Funciones";
            Load += FrmFuncionesSeleccionar_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
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
    }
}
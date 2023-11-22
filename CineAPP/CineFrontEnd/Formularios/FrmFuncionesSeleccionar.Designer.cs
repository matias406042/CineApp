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
            groupBox1 = new GroupBox();
            dgvFunciones = new DataGridView();
            colIdFuncion = new DataGridViewTextBoxColumn();
            colTitulo = new DataGridViewTextBoxColumn();
            colGenero = new DataGridViewTextBoxColumn();
            colInicio = new DataGridViewTextBoxColumn();
            colFin = new DataGridViewTextBoxColumn();
            colSala = new DataGridViewTextBoxColumn();
            btnAdd = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(134, 21);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 308);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 22);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(115, 308);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 22);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(14, 34);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(105, 23);
            dtpFecha.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(607, 308);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(82, 22);
            btnExit.TabIndex = 5;
            btnExit.Text = "CERRAR";
            btnExit.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvFunciones);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(9, 15);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(679, 293);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda Por Fecha";
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunciones.Columns.AddRange(new DataGridViewColumn[] { colIdFuncion, colTitulo, colGenero, colInicio, colFin, colSala });
            dgvFunciones.Location = new Point(0, 59);
            dgvFunciones.Margin = new Padding(3, 2, 3, 2);
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.RowTemplate.Height = 29;
            dgvFunciones.Size = new Size(683, 225);
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
            btnAdd.Location = new Point(226, 308);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 22);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "AÑADIR NUEVA";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // FrmFuncionesSeleccionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnAdd);
            Controls.Add(dtpFecha);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFuncionesSeleccionar";
            Text = "Funciones";
            groupBox1.ResumeLayout(false);
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
        private GroupBox groupBox1;
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
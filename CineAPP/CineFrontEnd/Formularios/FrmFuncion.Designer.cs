namespace CineFrontEnd.Formularios
{
    partial class FrmFuncion
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
            btnInsert = new Button();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            cboGenero = new ComboBox();
            lblPelicula = new Label();
            lblHorario = new Label();
            lblGenero = new Label();
            txtTitulo = new TextBox();
            lblNombre = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvPelis = new DataGridView();
            btnSalir = new Button();
            lblSALA = new Label();
            cboSala = new ComboBox();
            lblTipo = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            txtDimension = new TextBox();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            colId = new DataGridViewTextBoxColumn();
            ColTitulo = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColDuracion = new DataGridViewTextBoxColumn();
            ColDirector = new DataGridViewTextBoxColumn();
            ColEstreno = new DataGridViewTextBoxColumn();
            ColClasif = new DataGridViewTextBoxColumn();
            colProd = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPelis).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(21, 305);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(86, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "AGREGAR";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(567, 25);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(555, 48);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(94, 23);
            dtpFecha.TabIndex = 3;
            dtpFecha.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(259, 134);
            cboGenero.Margin = new Padding(3, 2, 3, 2);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(133, 23);
            cboGenero.TabIndex = 4;
            cboGenero.SelectedIndexChanged += cboGenero_SelectedIndexChanged;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(21, 106);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(59, 15);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "PELICULA";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(672, 25);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(97, 15);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "HORARIO INICIO";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(290, 106);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(52, 15);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "GENERO";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(108, 134);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(110, 23);
            txtTitulo.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(132, 106);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(45, 15);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "TITULO";
            // 
            // dgvPelis
            // 
            dgvPelis.AllowUserToAddRows = false;
            dgvPelis.AllowUserToDeleteRows = false;
            dgvPelis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelis.Columns.AddRange(new DataGridViewColumn[] { colId, ColTitulo, ColGenero, ColDuracion, ColDirector, ColEstreno, ColClasif, colProd });
            dgvPelis.Location = new Point(7, 166);
            dgvPelis.Margin = new Padding(3, 2, 3, 2);
            dgvPelis.Name = "dgvPelis";
            dgvPelis.ReadOnly = true;
            dgvPelis.RowHeadersWidth = 51;
            dgvPelis.RowTemplate.Height = 29;
            dgvPelis.Size = new Size(741, 133);
            dgvPelis.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(585, 305);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSALA
            // 
            lblSALA.AutoSize = true;
            lblSALA.Location = new Point(21, 16);
            lblSALA.Name = "lblSALA";
            lblSALA.Size = new Size(35, 15);
            lblSALA.TabIndex = 12;
            lblSALA.Text = "SALA";
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(65, 12);
            cboSala.Margin = new Padding(3, 2, 3, 2);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(133, 23);
            cboSala.TabIndex = 13;
            cboSala.SelectedIndexChanged += cboSala_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(224, 16);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(106, 15);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo de Dimensión";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(435, 134);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(82, 22);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(680, 89);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 18;
            label1.Text = "HORARIO FIN";
            // 
            // txtDimension
            // 
            txtDimension.Enabled = false;
            txtDimension.Location = new Point(347, 12);
            txtDimension.Margin = new Padding(3, 2, 3, 2);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(52, 23);
            txtDimension.TabIndex = 19;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(681, 114);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(82, 23);
            dtpFin.TabIndex = 20;
            dtpFin.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.AllowDrop = true;
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(681, 48);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(82, 23);
            dtpInicio.TabIndex = 21;
            dtpInicio.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // colId
            // 
            colId.HeaderText = "IdPeli";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // ColTitulo
            // 
            ColTitulo.HeaderText = "Titulo";
            ColTitulo.Name = "ColTitulo";
            ColTitulo.ReadOnly = true;
            ColTitulo.Width = 120;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 112;
            // 
            // ColDuracion
            // 
            ColDuracion.HeaderText = "Duracion";
            ColDuracion.Name = "ColDuracion";
            ColDuracion.ReadOnly = true;
            ColDuracion.Width = 112;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            ColDirector.Visible = false;
            ColDirector.Width = 112;
            // 
            // ColEstreno
            // 
            ColEstreno.HeaderText = "Año de estreno";
            ColEstreno.Name = "ColEstreno";
            ColEstreno.ReadOnly = true;
            ColEstreno.Width = 112;
            // 
            // ColClasif
            // 
            ColClasif.HeaderText = "Clasificacion";
            ColClasif.Name = "ColClasif";
            ColClasif.ReadOnly = true;
            ColClasif.Width = 112;
            // 
            // colProd
            // 
            colProd.HeaderText = "Productora";
            colProd.Name = "colProd";
            colProd.ReadOnly = true;
            colProd.Width = 120;
            // 
            // FrmFuncion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(775, 350);
            Controls.Add(dtpInicio);
            Controls.Add(dtpFin);
            Controls.Add(txtDimension);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(lblTipo);
            Controls.Add(cboSala);
            Controls.Add(lblSALA);
            Controls.Add(btnSalir);
            Controls.Add(dgvPelis);
            Controls.Add(lblNombre);
            Controls.Add(txtTitulo);
            Controls.Add(lblGenero);
            Controls.Add(lblHorario);
            Controls.Add(lblPelicula);
            Controls.Add(cboGenero);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(btnInsert);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmFuncion";
            Text = "Funcion";
            Load += FrmFuncion_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPelis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private ComboBox cboGenero;
        private Label lblPelicula;
        private Label lblHorario;
        private Label lblGenero;
        private TextBox txtTitulo;
        private Label lblNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvPelis;
        private Button btnSalir;
        private Label lblSALA;
        private ComboBox cboSala;
        private Label lblTipo;
        private Button btnBuscar;
        private Button btnUpdate;
        private Button btnDelete;
        private System.CodeDom.CodeTypeReference button1;
        private Label label1;
        private TextBox txtDimension;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn ColTitulo;
        private DataGridViewTextBoxColumn ColGenero;
        private DataGridViewTextBoxColumn ColDuracion;
        private DataGridViewTextBoxColumn ColDirector;
        private DataGridViewTextBoxColumn ColEstreno;
        private DataGridViewTextBoxColumn ColClasif;
        private DataGridViewTextBoxColumn colProd;
    }
}
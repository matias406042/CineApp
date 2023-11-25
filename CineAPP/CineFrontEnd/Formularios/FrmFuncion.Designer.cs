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
            colId = new DataGridViewTextBoxColumn();
            ColTitulo = new DataGridViewTextBoxColumn();
            ColGenero = new DataGridViewTextBoxColumn();
            ColDuracion = new DataGridViewTextBoxColumn();
            ColDirector = new DataGridViewTextBoxColumn();
            ColEstreno = new DataGridViewTextBoxColumn();
            ColClasif = new DataGridViewTextBoxColumn();
            colProd = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            lblSALA = new Label();
            cboSala = new ComboBox();
            lblTipo = new Label();
            btnBuscar = new Button();
            label1 = new Label();
            txtDimension = new TextBox();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvPelis).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(64, 64, 64);
            btnInsert.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnInsert.FlatAppearance.BorderSize = 3;
            btnInsert.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.LightGray;
            btnInsert.Location = new Point(8, 427);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(98, 39);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "AGREGAR";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.LightGray;
            lblFecha.Location = new Point(555, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(56, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(531, 63);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(107, 27);
            dtpFecha.TabIndex = 3;
            dtpFecha.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(8, 157);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(151, 28);
            cboGenero.TabIndex = 4;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPelicula.ForeColor = Color.LightGray;
            lblPelicula.Location = new Point(77, 29);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(82, 20);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "PELICULA:";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.LightGray;
            lblHorario.Location = new Point(689, 35);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(129, 20);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "HORARIO INICIO";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.LightGray;
            lblGenero.Location = new Point(37, 121);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(69, 20);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "GENERO";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(8, 65);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(151, 27);
            txtTitulo.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.LightGray;
            lblNombre.Location = new Point(8, 29);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "TITULO";
            // 
            // dgvPelis
            // 
            dgvPelis.AllowUserToAddRows = false;
            dgvPelis.AllowUserToDeleteRows = false;
            dgvPelis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelis.Columns.AddRange(new DataGridViewColumn[] { colId, ColTitulo, ColGenero, ColDuracion, ColDirector, ColEstreno, ColClasif, colProd });
            dgvPelis.Location = new Point(8, 191);
            dgvPelis.Name = "dgvPelis";
            dgvPelis.ReadOnly = true;
            dgvPelis.RowHeadersWidth = 51;
            dgvPelis.RowTemplate.Height = 29;
            dgvPelis.Size = new Size(709, 196);
            dgvPelis.TabIndex = 10;
            // 
            // colId
            // 
            colId.HeaderText = "IdPeli";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            colId.Width = 125;
            // 
            // ColTitulo
            // 
            ColTitulo.HeaderText = "Titulo";
            ColTitulo.MinimumWidth = 6;
            ColTitulo.Name = "ColTitulo";
            ColTitulo.ReadOnly = true;
            ColTitulo.Width = 145;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.MinimumWidth = 6;
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 95;
            // 
            // ColDuracion
            // 
            ColDuracion.HeaderText = "Duracion";
            ColDuracion.MinimumWidth = 6;
            ColDuracion.Name = "ColDuracion";
            ColDuracion.ReadOnly = true;
            ColDuracion.Width = 80;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.MinimumWidth = 6;
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            ColDirector.Visible = false;
            ColDirector.Width = 125;
            // 
            // ColEstreno
            // 
            ColEstreno.HeaderText = "Estreno";
            ColEstreno.MinimumWidth = 6;
            ColEstreno.Name = "ColEstreno";
            ColEstreno.ReadOnly = true;
            ColEstreno.Width = 95;
            // 
            // ColClasif
            // 
            ColClasif.HeaderText = "Clasificacion";
            ColClasif.MinimumWidth = 6;
            ColClasif.Name = "ColClasif";
            ColClasif.ReadOnly = true;
            ColClasif.Width = 95;
            // 
            // colProd
            // 
            colProd.HeaderText = "Productora";
            colProd.MinimumWidth = 6;
            colProd.Name = "colProd";
            colProd.ReadOnly = true;
            colProd.Width = 145;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(50, 0, 0);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(100, 0, 0);
            btnSalir.FlatAppearance.BorderSize = 3;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, 0, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(734, 427);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(96, 39);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSALA
            // 
            lblSALA.AutoSize = true;
            lblSALA.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSALA.ForeColor = Color.LightGray;
            lblSALA.Location = new Point(377, 65);
            lblSALA.Name = "lblSALA";
            lblSALA.Size = new Size(47, 20);
            lblSALA.TabIndex = 12;
            lblSALA.Text = "SALA";
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(427, 60);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(86, 28);
            cboSala.TabIndex = 13;
            cboSala.SelectedIndexChanged += cboSala_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.LightGray;
            lblTipo.Location = new Point(383, 99);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(44, 20);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo:";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(64, 64, 64);
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnBuscar.FlatAppearance.BorderSize = 3;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.LightGray;
            btnBuscar.Location = new Point(165, 155);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 30);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(699, 115);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 18;
            label1.Text = "HORARIO FIN";
            // 
            // txtDimension
            // 
            txtDimension.Enabled = false;
            txtDimension.Location = new Point(427, 94);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(59, 27);
            txtDimension.TabIndex = 19;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(700, 148);
            dtpFin.Margin = new Padding(3, 4, 3, 4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(93, 27);
            dtpFin.TabIndex = 20;
            dtpFin.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            dtpInicio.AllowDrop = true;
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(700, 65);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(93, 27);
            dtpInicio.TabIndex = 21;
            dtpInicio.Value = new DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // FrmFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(831, 467);
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
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
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
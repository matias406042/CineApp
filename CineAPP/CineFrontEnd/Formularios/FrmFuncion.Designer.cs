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
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.lblPelicula = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvPelis = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDirector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColClasif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSALA = new System.Windows.Forms.Label();
            this.cboSala = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDimension = new System.Windows.Forms.TextBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInsert.FlatAppearance.BorderSize = 3;
            this.btnInsert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.LightGray;
            this.btnInsert.Location = new System.Drawing.Point(21, 286);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 42);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "AGREGAR";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFecha.ForeColor = System.Drawing.Color.LightGray;
            this.lblFecha.Location = new System.Drawing.Point(500, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 15);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(488, 43);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(94, 23);
            this.dtpFecha.TabIndex = 3;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(259, 116);
            this.cboGenero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(133, 23);
            this.cboGenero.TabIndex = 4;
            // 
            // lblPelicula
            // 
            this.lblPelicula.AutoSize = true;
            this.lblPelicula.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPelicula.ForeColor = System.Drawing.Color.LightGray;
            this.lblPelicula.Location = new System.Drawing.Point(179, 20);
            this.lblPelicula.Name = "lblPelicula";
            this.lblPelicula.Size = new System.Drawing.Size(63, 15);
            this.lblPelicula.TabIndex = 5;
            this.lblPelicula.Text = "PELICULA:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.ForeColor = System.Drawing.Color.LightGray;
            this.lblHorario.Location = new System.Drawing.Point(605, 20);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(102, 15);
            this.lblHorario.TabIndex = 6;
            this.lblHorario.Text = "HORARIO INICIO";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.LightGray;
            this.lblGenero.Location = new System.Drawing.Point(259, 84);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(54, 15);
            this.lblGenero.TabIndex = 7;
            this.lblGenero.Text = "GENERO";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(259, 47);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(133, 23);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.LightGray;
            this.lblNombre.Location = new System.Drawing.Point(259, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(49, 15);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "TITULO";
            // 
            // dgvPelis
            // 
            this.dgvPelis.AllowUserToAddRows = false;
            this.dgvPelis.AllowUserToDeleteRows = false;
            this.dgvPelis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPelis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.ColTitulo,
            this.ColGenero,
            this.ColDuracion,
            this.ColDirector,
            this.ColEstreno,
            this.ColClasif,
            this.colProd});
            this.dgvPelis.Location = new System.Drawing.Point(7, 143);
            this.dgvPelis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPelis.Name = "dgvPelis";
            this.dgvPelis.ReadOnly = true;
            this.dgvPelis.RowHeadersWidth = 51;
            this.dgvPelis.RowTemplate.Height = 29;
            this.dgvPelis.Size = new System.Drawing.Size(713, 139);
            this.dgvPelis.TabIndex = 10;
            // 
            // colId
            // 
            this.colId.HeaderText = "IdPeli";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 125;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "Titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.ReadOnly = true;
            this.ColTitulo.Width = 145;
            // 
            // ColGenero
            // 
            this.ColGenero.HeaderText = "Genero";
            this.ColGenero.MinimumWidth = 6;
            this.ColGenero.Name = "ColGenero";
            this.ColGenero.ReadOnly = true;
            this.ColGenero.Width = 95;
            // 
            // ColDuracion
            // 
            this.ColDuracion.HeaderText = "Duracion";
            this.ColDuracion.MinimumWidth = 6;
            this.ColDuracion.Name = "ColDuracion";
            this.ColDuracion.ReadOnly = true;
            this.ColDuracion.Width = 80;
            // 
            // ColDirector
            // 
            this.ColDirector.HeaderText = "Director";
            this.ColDirector.MinimumWidth = 6;
            this.ColDirector.Name = "ColDirector";
            this.ColDirector.ReadOnly = true;
            this.ColDirector.Visible = false;
            this.ColDirector.Width = 125;
            // 
            // ColEstreno
            // 
            this.ColEstreno.HeaderText = "Estreno";
            this.ColEstreno.MinimumWidth = 6;
            this.ColEstreno.Name = "ColEstreno";
            this.ColEstreno.ReadOnly = true;
            this.ColEstreno.Width = 95;
            // 
            // ColClasif
            // 
            this.ColClasif.HeaderText = "Clasificacion";
            this.ColClasif.MinimumWidth = 6;
            this.ColClasif.Name = "ColClasif";
            this.ColClasif.ReadOnly = true;
            this.ColClasif.Width = 95;
            // 
            // colProd
            // 
            this.colProd.HeaderText = "Productora";
            this.colProd.MinimumWidth = 6;
            this.colProd.Name = "colProd";
            this.colProd.ReadOnly = true;
            this.colProd.Width = 145;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.BorderSize = 3;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalir.Location = new System.Drawing.Point(589, 286);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 42);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSALA
            // 
            this.lblSALA.AutoSize = true;
            this.lblSALA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSALA.ForeColor = System.Drawing.Color.LightGray;
            this.lblSALA.Location = new System.Drawing.Point(20, 46);
            this.lblSALA.Name = "lblSALA";
            this.lblSALA.Size = new System.Drawing.Size(36, 15);
            this.lblSALA.TabIndex = 12;
            this.lblSALA.Text = "SALA";
            // 
            // cboSala
            // 
            this.cboSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSala.FormattingEnabled = true;
            this.cboSala.Location = new System.Drawing.Point(64, 42);
            this.cboSala.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSala.Name = "cboSala";
            this.cboSala.Size = new System.Drawing.Size(76, 23);
            this.cboSala.TabIndex = 13;
            this.cboSala.SelectedIndexChanged += new System.EventHandler(this.cboSala_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.ForeColor = System.Drawing.Color.LightGray;
            this.lblTipo.Location = new System.Drawing.Point(25, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(34, 15);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatAppearance.BorderSize = 3;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(488, 89);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(82, 43);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(613, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "HORARIO FIN";
            // 
            // txtDimension
            // 
            this.txtDimension.Enabled = false;
            this.txtDimension.Location = new System.Drawing.Point(64, 81);
            this.txtDimension.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDimension.Name = "txtDimension";
            this.txtDimension.Size = new System.Drawing.Size(52, 23);
            this.txtDimension.TabIndex = 19;
            // 
            // dtpFin
            // 
            this.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFin.Location = new System.Drawing.Point(614, 109);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(82, 23);
            this.dtpFin.TabIndex = 20;
            this.dtpFin.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // dtpInicio
            // 
            this.dtpInicio.AllowDrop = true;
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInicio.Location = new System.Drawing.Point(614, 43);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(82, 23);
            this.dtpInicio.TabIndex = 21;
            this.dtpInicio.Value = new System.DateTime(2023, 11, 18, 0, 0, 0, 0);
            // 
            // FrmFuncion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(727, 350);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.txtDimension);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cboSala);
            this.Controls.Add(this.lblSALA);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPelis);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblPelicula);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFuncion";
            this.Text = "Funcion";
            this.Load += new System.EventHandler(this.FrmFuncion_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPelis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

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
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPelis).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.FlatAppearance.BorderColor = Color.Gainsboro;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.ForeColor = Color.Gainsboro;
            btnInsert.Location = new Point(551, 636);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(139, 53);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "AGREGAR";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.LightGray;
            lblFecha.Location = new Point(24, 500);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(56, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            dtpFecha.CalendarForeColor = Color.RosyBrown;
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(24, 523);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(129, 27);
            dtpFecha.TabIndex = 3;
            dtpFecha.ValueChanged += dtpFecha_ValueChanged;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new Point(24, 393);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(176, 28);
            cboGenero.TabIndex = 4;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.BackColor = Color.FromArgb(15, 15, 15);
            lblPelicula.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPelicula.ForeColor = Color.FromArgb(229, 9, 20);
            lblPelicula.Location = new Point(24, 231);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(98, 20);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "PELICULA";
            lblPelicula.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.BackColor = Color.Transparent;
            lblHorario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHorario.ForeColor = Color.LightGray;
            lblHorario.Location = new Point(24, 563);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(129, 20);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "HORARIO INICIO";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.BackColor = Color.FromArgb(15, 15, 15);
            lblGenero.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblGenero.ForeColor = Color.LightGray;
            lblGenero.Location = new Point(24, 358);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(71, 16);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "GENERO";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(24, 303);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(176, 27);
            txtTitulo.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.FromArgb(15, 15, 15);
            lblNombre.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.LightGray;
            lblNombre.Location = new Point(24, 284);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(61, 16);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "TITULO";
            // 
            // dgvPelis
            // 
            dgvPelis.AllowUserToAddRows = false;
            dgvPelis.AllowUserToDeleteRows = false;
            dgvPelis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelis.Columns.AddRange(new DataGridViewColumn[] { colId, ColTitulo, ColGenero, ColDuracion, ColDirector, ColEstreno, ColClasif, colProd });
            dgvPelis.Location = new Point(293, 111);
            dgvPelis.Name = "dgvPelis";
            dgvPelis.ReadOnly = true;
            dgvPelis.RowHeadersWidth = 51;
            dgvPelis.RowTemplate.Height = 29;
            dgvPelis.Size = new Size(927, 503);
            dgvPelis.TabIndex = 10;
            dgvPelis.CellContentClick += dgvPelis_CellContentClick;
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
            ColTitulo.Width = 125;
            // 
            // ColGenero
            // 
            ColGenero.HeaderText = "Genero";
            ColGenero.MinimumWidth = 6;
            ColGenero.Name = "ColGenero";
            ColGenero.ReadOnly = true;
            ColGenero.Width = 125;
            // 
            // ColDuracion
            // 
            ColDuracion.HeaderText = "Duracion";
            ColDuracion.MinimumWidth = 6;
            ColDuracion.Name = "ColDuracion";
            ColDuracion.ReadOnly = true;
            ColDuracion.Width = 125;
            // 
            // ColDirector
            // 
            ColDirector.HeaderText = "Director";
            ColDirector.MinimumWidth = 6;
            ColDirector.Name = "ColDirector";
            ColDirector.ReadOnly = true;
            ColDirector.Width = 125;
            // 
            // ColEstreno
            // 
            ColEstreno.HeaderText = "Año de estreno";
            ColEstreno.MinimumWidth = 6;
            ColEstreno.Name = "ColEstreno";
            ColEstreno.ReadOnly = true;
            ColEstreno.Width = 125;
            // 
            // ColClasif
            // 
            ColClasif.HeaderText = "Clasificacion";
            ColClasif.MinimumWidth = 6;
            ColClasif.Name = "ColClasif";
            ColClasif.ReadOnly = true;
            ColClasif.Width = 125;
            // 
            // colProd
            // 
            colProd.HeaderText = "Productora";
            colProd.MinimumWidth = 6;
            colProd.Name = "colProd";
            colProd.ReadOnly = true;
            colProd.Width = 125;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(51, 51, 51);
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.LightGray;
            btnSalir.Location = new Point(1062, 636);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(148, 53);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblSALA
            // 
            lblSALA.AutoSize = true;
            lblSALA.BackColor = Color.FromArgb(15, 15, 15);
            lblSALA.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSALA.ForeColor = Color.LightGray;
            lblSALA.Location = new Point(24, 115);
            lblSALA.Name = "lblSALA";
            lblSALA.Size = new Size(48, 18);
            lblSALA.TabIndex = 12;
            lblSALA.Text = "SALA";
            // 
            // cboSala
            // 
            cboSala.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(92, 111);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(151, 28);
            cboSala.TabIndex = 13;
            cboSala.SelectedIndexChanged += cboSala_SelectedIndexChanged;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(15, 15, 15);
            lblTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTipo.ForeColor = Color.LightGray;
            lblTipo.Location = new Point(24, 167);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(101, 18);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "DIMENSIÓN";
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderColor = Color.Gainsboro;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.Gainsboro;
            btnBuscar.Location = new Point(340, 636);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(141, 53);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(24, 636);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 18;
            label1.Text = "HORARIO FIN";
            // 
            // txtDimension
            // 
            txtDimension.Enabled = false;
            txtDimension.Location = new Point(151, 158);
            txtDimension.Name = "txtDimension";
            txtDimension.Size = new Size(92, 27);
            txtDimension.TabIndex = 19;
            // 
            // dtpFin
            // 
            dtpFin.Format = DateTimePickerFormat.Time;
            dtpFin.Location = new Point(24, 660);
            dtpFin.Margin = new Padding(3, 4, 3, 4);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(129, 27);
            dtpFin.TabIndex = 20;
            dtpFin.ValueChanged += dtpFin_ValueChanged;
            // 
            // dtpInicio
            // 
            dtpInicio.Format = DateTimePickerFormat.Time;
            dtpInicio.Location = new Point(24, 587);
            dtpInicio.Margin = new Padding(3, 4, 3, 4);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(129, 27);
            dtpInicio.TabIndex = 21;
            dtpInicio.ValueChanged += dtpInicio_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 15, 15);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblPelicula);
            panel1.Controls.Add(lblSALA);
            panel1.Controls.Add(dtpInicio);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblHorario);
            panel1.Controls.Add(lblGenero);
            panel1.Controls.Add(dtpFin);
            panel1.Controls.Add(cboGenero);
            panel1.Controls.Add(txtTitulo);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(lblNombre);
            panel1.Controls.Add(cboSala);
            panel1.Controls.Add(lblTipo);
            panel1.Controls.Add(txtDimension);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 719);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(15, 15, 15);
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 9, 20);
            label4.Location = new Point(24, 59);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 24;
            label4.Text = "PROYECCIÓN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(15, 15, 15);
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(229, 9, 20);
            label3.Location = new Point(24, 460);
            label3.Name = "label3";
            label3.Size = new Size(147, 20);
            label3.TabIndex = 20;
            label3.Text = "FECHA Y HORA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 51, 51);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(293, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(942, 108);
            panel2.TabIndex = 23;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(351, 29);
            label2.Name = "label2";
            label2.Size = new Size(205, 50);
            label2.TabIndex = 20;
            label2.Text = " Funciones";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // FrmFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(1222, 719);
            Controls.Add(dgvPelis);
            Controls.Add(btnSalir);
            Controls.Add(btnInsert);
            Controls.Add(btnBuscar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmFuncion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcion";
            ((System.ComponentModel.ISupportInitialize)dgvPelis).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
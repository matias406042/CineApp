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
            cboHorario = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            t = new ComboBox();
            lblPelicula = new Label();
            lblHorario = new Label();
            lblGenero = new Label();
            textBox1 = new TextBox();
            lblNombre = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            btnSalir = new Button();
            lblSALA = new Label();
            cboSala = new ComboBox();
            lblTipo = new Label();
            cboTipo = new ComboBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(24, 407);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(98, 31);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "AGREGAR";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnAGREGAR_Click;
            // 
            // cboHorario
            // 
            cboHorario.FormattingEnabled = true;
            cboHorario.Location = new Point(616, 56);
            cboHorario.Name = "cboHorario";
            cboHorario.Size = new Size(151, 28);
            cboHorario.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(526, 21);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "FECHA";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(497, 57);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(107, 27);
            dtpFecha.TabIndex = 3;
            // 
            // t
            // 
            t.FormattingEnabled = true;
            t.Location = new Point(296, 179);
            t.Name = "t";
            t.Size = new Size(151, 28);
            t.TabIndex = 4;
            t.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblPelicula
            // 
            lblPelicula.AutoSize = true;
            lblPelicula.Location = new Point(26, 182);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(72, 20);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "PELICULA";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(653, 21);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(74, 20);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "HORARIO";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(336, 138);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(66, 20);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "GENERO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 8;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(145, 138);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(70, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "NOMBRE";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 222);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(743, 177);
            dataGridView1.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 407);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 31);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblSALA
            // 
            lblSALA.AutoSize = true;
            lblSALA.Location = new Point(24, 21);
            lblSALA.Name = "lblSALA";
            lblSALA.Size = new Size(44, 20);
            lblSALA.TabIndex = 12;
            lblSALA.Text = "SALA";
            // 
            // cboSala
            // 
            cboSala.FormattingEnabled = true;
            cboSala.Location = new Point(74, 18);
            cboSala.Name = "cboSala";
            cboSala.Size = new Size(151, 28);
            cboSala.TabIndex = 13;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(245, 21);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(40, 20);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "TIPO";
            // 
            // cboTipo
            // 
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(291, 18);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(151, 28);
            cboTipo.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(497, 179);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBuscar);
            Controls.Add(cboTipo);
            Controls.Add(lblTipo);
            Controls.Add(cboSala);
            Controls.Add(lblSALA);
            Controls.Add(btnSalir);
            Controls.Add(dataGridView1);
            Controls.Add(lblNombre);
            Controls.Add(textBox1);
            Controls.Add(lblGenero);
            Controls.Add(lblHorario);
            Controls.Add(lblPelicula);
            Controls.Add(t);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cboHorario);
            Controls.Add(btnInsert);
            Name = "FrmFuncion";
            Text = "Funcion";
            Load += FrmFuncion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private ComboBox cboHorario;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private ComboBox t;
        private Label lblPelicula;
        private Label lblHorario;
        private Label lblGenero;
        private TextBox textBox1;
        private Label lblNombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private Button btnSalir;
        private Label lblSALA;
        private ComboBox cboSala;
        private Label lblTipo;
        private ComboBox cboTipo;
        private Button btnBuscar;
        private Button btnUpdate;
        private Button btnDelete;
        private System.CodeDom.CodeTypeReference button1;
    }
}
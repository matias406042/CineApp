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
            btnBuscar = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
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
            lblFecha.Location = new Point(511, 26);
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
            lblPelicula.Location = new Point(24, 142);
            lblPelicula.Name = "lblPelicula";
            lblPelicula.Size = new Size(72, 20);
            lblPelicula.TabIndex = 5;
            lblPelicula.Text = "PELICULA";
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(631, 26);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(121, 20);
            lblHorario.TabIndex = 6;
            lblHorario.Text = "HORARIO INICIO";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new Point(331, 156);
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
            lblNombre.Location = new Point(151, 156);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "TITULO";
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
            lblTipo.Location = new Point(25, 64);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(135, 20);
            lblTipo.TabIndex = 14;
            lblTipo.Text = "Tipo de Dimensión";
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
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(616, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 112);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 18;
            label1.Text = "HORARIO FIN";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(166, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(59, 27);
            textBox3.TabIndex = 19;
            // 
            // FrmFuncion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(btnBuscar);
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
        private Button btnBuscar;
        private Button btnUpdate;
        private Button btnDelete;
        private System.CodeDom.CodeTypeReference button1;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
    }
}
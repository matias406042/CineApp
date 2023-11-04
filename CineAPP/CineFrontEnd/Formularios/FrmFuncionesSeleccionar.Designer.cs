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
            btnEditar = new Button();
            btnDelete = new Button();
            dtpFuncionesBuscar = new DateTimePicker();
            btnExit = new Button();
            ColumnPelicula = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            ColumnHora = new DataGridViewTextBoxColumn();
            ColumnSala = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(241, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Search";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(12, 411);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "UPDATE";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(131, 411);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtpFuncionesBuscar
            // 
            dtpFuncionesBuscar.Format = DateTimePickerFormat.Short;
            dtpFuncionesBuscar.Location = new Point(16, 46);
            dtpFuncionesBuscar.Name = "dtpFuncionesBuscar";
            dtpFuncionesBuscar.Size = new Size(218, 27);
            dtpFuncionesBuscar.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(694, 411);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "CLOSE";
            btnExit.UseVisualStyleBackColor = true;
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
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnBuscar);
            groupBox1.Location = new Point(10, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 391);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Busqueda Por Fecha";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(781, 300);
            dataGridView1.TabIndex = 1;
            // 
            // FrmFuncionesSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpFuncionesBuscar);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnEditar);
            Name = "FrmFuncionesSeleccionar";
            Text = "Funciones";
            Load += FrmFuncionesSeleccionar_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnEditar;
        private Button btnDelete;
        private DateTimePicker dtpFuncionesBuscar;
        private Button btnExit;
        private DataGridViewTextBoxColumn ColumnPelicula;
        private DataGridViewTextBoxColumn ColumnFecha;
        private DataGridViewTextBoxColumn ColumnHora;
        private DataGridViewTextBoxColumn ColumnSala;
        private DataGridViewTextBoxColumn ColumnTipo;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
    }
}
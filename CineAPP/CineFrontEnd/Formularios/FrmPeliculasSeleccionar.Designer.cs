namespace CineFrontEnd.Formularios
{
    partial class FrmPeliculasSeleccionar
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
            dgvPelicula = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            btnUpdate = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSerch = new Button();
            cbxTitulo = new CheckBox();
            cbxGenero = new CheckBox();
            cbxFecha = new CheckBox();
            txbTitulo = new TextBox();
            txbAño = new TextBox();
            cmbGenero = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPelicula
            // 
            dgvPelicula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPelicula.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPelicula.Location = new Point(315, 0);
            dgvPelicula.Name = "dgvPelicula";
            dgvPelicula.RowHeadersWidth = 51;
            dgvPelicula.RowTemplate.Height = 29;
            dgvPelicula.Size = new Size(432, 351);
            dgvPelicula.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "TITULO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "GENERO";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "FECHA ESTRENO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Black;
            btnUpdate.FlatAppearance.BorderSize = 2;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Gainsboro;
            btnUpdate.Location = new Point(165, 428);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(131, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "ACTUALIZAR";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(51, 51, 51);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnClose.FlatAppearance.BorderSize = 4;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Gainsboro;
            btnClose.Location = new Point(605, 408);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(129, 48);
            btnClose.TabIndex = 9;
            btnClose.Text = "SALIR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderSize = 2;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Gainsboro;
            btnDelete.Location = new Point(25, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 49);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "ELIMINAR";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 2;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Gainsboro;
            btnAdd.Location = new Point(25, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 49);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "AGREGAR";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSerch
            // 
            btnSerch.BackColor = Color.Black;
            btnSerch.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnSerch.FlatStyle = FlatStyle.Flat;
            btnSerch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSerch.ForeColor = Color.LightGray;
            btnSerch.Location = new Point(165, 357);
            btnSerch.Name = "btnSerch";
            btnSerch.Size = new Size(131, 49);
            btnSerch.TabIndex = 0;
            btnSerch.Text = "BUSCAR";
            btnSerch.UseVisualStyleBackColor = false;
            btnSerch.Click += btnSerch_Click;
            // 
            // cbxTitulo
            // 
            cbxTitulo.AutoSize = true;
            cbxTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxTitulo.ForeColor = Color.LightGray;
            cbxTitulo.Location = new Point(25, 94);
            cbxTitulo.Name = "cbxTitulo";
            cbxTitulo.Size = new Size(84, 24);
            cbxTitulo.TabIndex = 1;
            cbxTitulo.Text = "TITULO";
            cbxTitulo.UseVisualStyleBackColor = true;
            cbxTitulo.CheckedChanged += cbxTitulo_CheckedChanged;
            // 
            // cbxGenero
            // 
            cbxGenero.AutoSize = true;
            cbxGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxGenero.ForeColor = Color.LightGray;
            cbxGenero.Location = new Point(25, 173);
            cbxGenero.Name = "cbxGenero";
            cbxGenero.Size = new Size(91, 24);
            cbxGenero.TabIndex = 2;
            cbxGenero.Text = "GENERO";
            cbxGenero.UseVisualStyleBackColor = true;
            cbxGenero.CheckedChanged += cbxGenero_CheckedChanged;
            // 
            // cbxFecha
            // 
            cbxFecha.AutoSize = true;
            cbxFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxFecha.ForeColor = Color.LightGray;
            cbxFecha.Location = new Point(25, 257);
            cbxFecha.Name = "cbxFecha";
            cbxFecha.Size = new Size(135, 24);
            cbxFecha.TabIndex = 3;
            cbxFecha.Text = "AÑO ESTRENO";
            cbxFecha.UseVisualStyleBackColor = true;
            cbxFecha.CheckedChanged += cbxFecha_CheckedChanged;
            // 
            // txbTitulo
            // 
            txbTitulo.Location = new Point(25, 124);
            txbTitulo.Name = "txbTitulo";
            txbTitulo.Size = new Size(125, 27);
            txbTitulo.TabIndex = 5;
            // 
            // txbAño
            // 
            txbAño.Location = new Point(25, 287);
            txbAño.Name = "txbAño";
            txbAño.Size = new Size(125, 27);
            txbAño.TabIndex = 9;
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Location = new Point(25, 203);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(125, 28);
            cmbGenero.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSerch);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cbxGenero);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(txbAño);
            panel1.Controls.Add(cmbGenero);
            panel1.Controls.Add(cbxFecha);
            panel1.Controls.Add(txbTitulo);
            panel1.Controls.Add(cbxTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 482);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(229, 9, 20);
            label4.Location = new Point(25, 42);
            label4.Name = "label4";
            label4.Size = new Size(271, 24);
            label4.TabIndex = 25;
            label4.Text = "BUSQUEDA DE PELICULAS";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Gainsboro;
            button2.Location = new Point(327, 381);
            button2.Name = "button2";
            button2.Size = new Size(221, 75);
            button2.TabIndex = 9;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnClose_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Gainsboro;
            button1.Location = new Point(327, 301);
            button1.Name = "button1";
            button1.Size = new Size(221, 74);
            button1.TabIndex = 8;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnUpdate_Click;
            // 
            // FrmPeliculasSeleccionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(746, 482);
            Controls.Add(dgvPelicula);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPeliculasSeleccionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seleccion de Peliculas";
            Load += FrmPeliculasSeleccionar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPelicula).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvPelicula;
        private Button btnUpdate;
        private Button btnClose;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnSerch;
        private CheckBox cbxTitulo;
        private CheckBox cbxGenero;
        private CheckBox cbxFecha;
        private TextBox txbTitulo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ComboBox cmbGenero;
        private TextBox txbAño;
        private Panel panel1;
        private Label label4;
        private Button button2;
        private Button button1;
    }
}
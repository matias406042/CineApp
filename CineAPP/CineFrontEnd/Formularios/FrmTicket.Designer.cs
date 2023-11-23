namespace CineFrontEnd.Formularios
{
    partial class FrmTicket
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
            this.dgvFunciones = new System.Windows.Forms.DataGridView();
            this.ColFuncionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPElicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colhorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDIMENSION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColACCION = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txbTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbxTitulo = new System.Windows.Forms.CheckBox();
            this.cbxFecha = new System.Windows.Forms.CheckBox();
            this.btnButacas = new System.Windows.Forms.Button();
            this.txtButaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFunciones
            // 
            this.dgvFunciones.AllowUserToAddRows = false;
            this.dgvFunciones.AllowUserToDeleteRows = false;
            this.dgvFunciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColFuncionID,
            this.ColPElicula,
            this.Colhorario,
            this.Column1,
            this.ColSala,
            this.ColDIMENSION,
            this.ColPrecio,
            this.ColACCION});
            this.dgvFunciones.Location = new System.Drawing.Point(10, 112);
            this.dgvFunciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFunciones.Name = "dgvFunciones";
            this.dgvFunciones.ReadOnly = true;
            this.dgvFunciones.RowHeadersWidth = 51;
            this.dgvFunciones.RowTemplate.Height = 29;
            this.dgvFunciones.Size = new System.Drawing.Size(933, 179);
            this.dgvFunciones.TabIndex = 0;
            // 
            // ColFuncionID
            // 
            this.ColFuncionID.HeaderText = "ID";
            this.ColFuncionID.Name = "ColFuncionID";
            this.ColFuncionID.ReadOnly = true;
            this.ColFuncionID.Visible = false;
            // 
            // ColPElicula
            // 
            this.ColPElicula.HeaderText = "PELICULA";
            this.ColPElicula.MinimumWidth = 6;
            this.ColPElicula.Name = "ColPElicula";
            this.ColPElicula.ReadOnly = true;
            this.ColPElicula.Width = 125;
            // 
            // Colhorario
            // 
            this.Colhorario.HeaderText = "HORARIO INICIO";
            this.Colhorario.MinimumWidth = 6;
            this.Colhorario.Name = "Colhorario";
            this.Colhorario.ReadOnly = true;
            this.Colhorario.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "HORARIO FIN";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // ColSala
            // 
            this.ColSala.HeaderText = "SALA";
            this.ColSala.MinimumWidth = 6;
            this.ColSala.Name = "ColSala";
            this.ColSala.ReadOnly = true;
            this.ColSala.Width = 125;
            // 
            // ColDIMENSION
            // 
            this.ColDIMENSION.HeaderText = "DIMENSION";
            this.ColDIMENSION.MinimumWidth = 6;
            this.ColDIMENSION.Name = "ColDIMENSION";
            this.ColDIMENSION.ReadOnly = true;
            this.ColDIMENSION.Width = 125;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "PRECIO";
            this.ColPrecio.MinimumWidth = 6;
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            this.ColPrecio.Width = 125;
            // 
            // ColACCION
            // 
            this.ColACCION.HeaderText = "ACCION";
            this.ColACCION.MinimumWidth = 6;
            this.ColACCION.Name = "ColACCION";
            this.ColACCION.ReadOnly = true;
            this.ColACCION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColACCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColACCION.Width = 125;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(397, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(196, 87);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(145, 23);
            this.dtpFecha.TabIndex = 4;
            // 
            // txbTitulo
            // 
            this.txbTitulo.Enabled = false;
            this.txbTitulo.Location = new System.Drawing.Point(31, 87);
            this.txbTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTitulo.Name = "txbTitulo";
            this.txbTitulo.Size = new System.Drawing.Size(125, 23);
            this.txbTitulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "BUSQUEDA DE FUNCION :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 307);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 22);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(858, 307);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 22);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbxTitulo
            // 
            this.cbxTitulo.AutoSize = true;
            this.cbxTitulo.Location = new System.Drawing.Point(31, 64);
            this.cbxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxTitulo.Name = "cbxTitulo";
            this.cbxTitulo.Size = new System.Drawing.Size(56, 19);
            this.cbxTitulo.TabIndex = 11;
            this.cbxTitulo.Text = "Titulo";
            this.cbxTitulo.UseVisualStyleBackColor = true;
            this.cbxTitulo.CheckedChanged += new System.EventHandler(this.cbxTitulo_CheckedChanged_1);
            // 
            // cbxFecha
            // 
            this.cbxFecha.AutoSize = true;
            this.cbxFecha.Enabled = false;
            this.cbxFecha.Location = new System.Drawing.Point(196, 64);
            this.cbxFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(57, 19);
            this.cbxFecha.TabIndex = 12;
            this.cbxFecha.Text = "Fecha";
            this.cbxFecha.UseVisualStyleBackColor = true;
            this.cbxFecha.Visible = false;
            // 
            // btnButacas
            // 
            this.btnButacas.Enabled = false;
            this.btnButacas.Location = new System.Drawing.Point(845, 43);
            this.btnButacas.Name = "btnButacas";
            this.btnButacas.Size = new System.Drawing.Size(75, 61);
            this.btnButacas.TabIndex = 13;
            this.btnButacas.Text = "ELEGIR BUTACA";
            this.btnButacas.UseVisualStyleBackColor = true;
            this.btnButacas.Click += new System.EventHandler(this.btnButacas_Click);
            // 
            // txtButaca
            // 
            this.txtButaca.Enabled = false;
            this.txtButaca.Location = new System.Drawing.Point(660, 81);
            this.txtButaca.Name = "txtButaca";
            this.txtButaca.Size = new System.Drawing.Size(179, 23);
            this.txtButaca.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(675, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Butaca seleccionada";
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtButaca);
            this.Controls.Add(this.btnButacas);
            this.Controls.Add(this.cbxFecha);
            this.Controls.Add(this.cbxTitulo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTitulo);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvFunciones);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTicket";
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvFunciones;
        private Button btnSearch;
        private DateTimePicker dtpFecha;
        private TextBox txbTitulo;
        private Label label1;
        private Button btnSave;
        private Button btnClose;
        private CheckBox cbxTitulo;
        private CheckBox cbxFecha;
        private Button btnButacas;
        public TextBox txtButaca;
        private Label label2;
        private DataGridViewTextBoxColumn ColFuncionID;
        private DataGridViewTextBoxColumn ColPElicula;
        private DataGridViewTextBoxColumn Colhorario;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ColSala;
        private DataGridViewTextBoxColumn ColDIMENSION;
        private DataGridViewTextBoxColumn ColPrecio;
        private DataGridViewCheckBoxColumn ColACCION;
    }
}
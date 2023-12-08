namespace CineFrontEnd.Reportes
{
    partial class frmReporteComprobantes
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
            label1 = new Label();
            label2 = new Label();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            btnGenerar = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 0;
            label1.Text = "Fecha desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(296, 25);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 1;
            label2.Text = "Fecha hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(161, 24);
            dtpDesde.Margin = new Padding(3, 4, 3, 4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(99, 27);
            dtpDesde.TabIndex = 2;
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(439, 24);
            dtpHasta.Margin = new Padding(3, 4, 3, 4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(99, 27);
            dtpHasta.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(64, 64, 64);
            btnGenerar.FlatAppearance.BorderColor = Color.FromArgb(40, 40, 40);
            btnGenerar.FlatAppearance.BorderSize = 3;
            btnGenerar.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 40, 40);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerar.ForeColor = Color.LightGray;
            btnGenerar.Location = new Point(574, 16);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(105, 39);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.ForeColor = Color.LightGray;
            reportViewer1.Location = new Point(6, 60);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(857, 533);
            reportViewer1.TabIndex = 0;
            // 
            // frmReporteComprobantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(875, 600);
            Controls.Add(reportViewer1);
            Controls.Add(btnGenerar);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReporteComprobantes";
            Text = "frmReporteComprobantes";
            Load += frmReporteComprobantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
namespace CineFrontEnd.Reportes
{
    partial class frmReportePeliculas
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
            cboSeleccion = new ComboBox();
            label1 = new Label();
            btnGenerar = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // cboSeleccion
            // 
            cboSeleccion.BackColor = Color.FromArgb(64, 64, 64);
            cboSeleccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeleccion.FormattingEnabled = true;
            cboSeleccion.Items.AddRange(new object[] { "GENERO", "CLASIFICACION", "PRODUCTORA" });
            cboSeleccion.Location = new Point(175, 16);
            cboSeleccion.Margin = new Padding(3, 4, 3, 4);
            cboSeleccion.Name = "cboSeleccion";
            cboSeleccion.Size = new Size(182, 28);
            cboSeleccion.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(33, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Reporte de";
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
            btnGenerar.Location = new Point(466, 11);
            btnGenerar.Margin = new Padding(3, 4, 3, 4);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(147, 36);
            btnGenerar.TabIndex = 2;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // reportViewer1
            // 
            reportViewer1.ForeColor = Color.LightGray;
            reportViewer1.Location = new Point(11, 60);
            reportViewer1.Margin = new Padding(3, 4, 3, 4);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(800, 533);
            reportViewer1.TabIndex = 0;
            // 
            // frmReportePeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(820, 601);
            Controls.Add(reportViewer1);
            Controls.Add(btnGenerar);
            Controls.Add(label1);
            Controls.Add(cboSeleccion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmReportePeliculas";
            Text = "frmReportePeliculas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboSeleccion;
        private Label label1;
        private Button btnGenerar;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}
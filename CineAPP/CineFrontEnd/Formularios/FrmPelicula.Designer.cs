namespace CineFrontEnd.Formularios
{
    partial class FrmPelicula
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpPeliculas = new DateTimePicker();
            label6 = new Label();
            btnSaveEdit = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            label12 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(51, 51, 51);
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(107, 314);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(51, 51, 51);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(440, 232);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(194, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(51, 51, 51);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(440, 153);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(194, 28);
            comboBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(51, 51, 51);
            textBox1.Location = new Point(107, 150);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(51, 51, 51);
            textBox2.Location = new Point(107, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(107, 126);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 5;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(107, 197);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 6;
            label2.Text = "DURACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(440, 200);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 7;
            label3.Text = "CLASIFICACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(107, 291);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 8;
            label4.Text = "GENERO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(440, 129);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 9;
            label5.Text = "PRODUCTORA";
            // 
            // dtpPeliculas
            // 
            dtpPeliculas.CalendarMonthBackground = Color.FromArgb(51, 51, 51);
            dtpPeliculas.Location = new Point(439, 315);
            dtpPeliculas.Name = "dtpPeliculas";
            dtpPeliculas.Size = new Size(195, 27);
            dtpPeliculas.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(440, 281);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "ESTRENO";
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.BackColor = Color.FromArgb(51, 51, 51);
            btnSaveEdit.FlatAppearance.BorderSize = 3;
            btnSaveEdit.FlatStyle = FlatStyle.Flat;
            btnSaveEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveEdit.ForeColor = Color.LightGray;
            btnSaveEdit.Location = new Point(166, 393);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(135, 36);
            btnSaveEdit.TabIndex = 13;
            btnSaveEdit.Text = "GUARDAR";
            btnSaveEdit.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(51, 51, 51);
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(229, 9, 20);
            btnClose.FlatAppearance.BorderSize = 4;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(229, 9, 20);
            btnClose.Location = new Point(440, 393);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 37);
            btnClose.TabIndex = 14;
            btnClose.Text = "SALIR";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 92);
            panel1.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(229, 9, 20);
            label12.Location = new Point(208, 26);
            label12.Name = "label12";
            label12.Size = new Size(320, 41);
            label12.TabIndex = 0;
            label12.Text = "AGREGAR PELICULAS";
            label12.Click += label12_Click;
            // 
            // FrmPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 51);
            ClientSize = new Size(748, 442);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnSaveEdit);
            Controls.Add(label6);
            Controls.Add(dtpPeliculas);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPelicula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pelicula";
            Load += FrmPelicula_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpPeliculas;
        private Label label6;
        private Button btnSaveEdit;
        private Button btnClose;
        private Panel panel1;
        private Label label12;
    }
}
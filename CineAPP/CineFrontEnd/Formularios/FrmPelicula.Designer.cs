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
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            btnSaveEdit = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 239);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(219, 239);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(412, 239);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 67);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 5;
            label1.Text = "TITULO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 67);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 6;
            label2.Text = "DURACION";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 216);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 7;
            label3.Text = "CLASIFICACION";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 216);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 8;
            label4.Text = "GENERO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(412, 216);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 9;
            label5.Text = "PRODUCTORA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(412, 88);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(412, 65);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 11;
            label6.Text = "ESTRENO";
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Location = new Point(607, 234);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(119, 36);
            btnSaveEdit.TabIndex = 13;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(704, 391);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(72, 37);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmPelicula
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSaveEdit);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
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
            Name = "FrmPelicula";
            Text = "Pelicula";
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
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button btnSaveEdit;
        private Button btnClose;
    }
}
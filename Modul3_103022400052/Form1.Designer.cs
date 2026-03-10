namespace Modul3_103022400052
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbSatuanAwal = new ComboBox();
            cbSatuanAkhir = new ComboBox();
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbSatuanAwal
            // 
            cbSatuanAwal.FormattingEnabled = true;
            cbSatuanAwal.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cbSatuanAwal.Location = new Point(132, 127);
            cbSatuanAwal.Name = "cbSatuanAwal";
            cbSatuanAwal.Size = new Size(112, 33);
            cbSatuanAwal.TabIndex = 0;
            cbSatuanAwal.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbSatuanAkhir
            // 
            cbSatuanAkhir.FormattingEnabled = true;
            cbSatuanAkhir.Items.AddRange(new object[] { "Celcius", "Fahrenheit", "Kelvin", "Reamur" });
            cbSatuanAkhir.Location = new Point(132, 238);
            cbSatuanAkhir.Name = "cbSatuanAkhir";
            cbSatuanAkhir.Size = new Size(112, 33);
            cbSatuanAkhir.TabIndex = 1;
            cbSatuanAkhir.SelectedIndexChanged += cbSatuanAkhir_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(333, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(593, 129);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 92);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 4;
            label1.Text = "Satuan Awal";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 201);
            label2.Name = "label2";
            label2.Size = new Size(112, 25);
            label2.TabIndex = 5;
            label2.Text = "Satuan Akhir";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(333, 240);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(198, 31);
            textBox2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(384, 92);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 7;
            label3.Text = "Nilai Awal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 201);
            label4.Name = "label4";
            label4.Size = new Size(92, 25);
            label4.TabIndex = 8;
            label4.Text = "Nilai Akhir";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(cbSatuanAkhir);
            Controls.Add(cbSatuanAwal);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSatuanAwal;
        private ComboBox cbSatuanAkhir;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
    }
}

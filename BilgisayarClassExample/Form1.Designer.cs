namespace BilgisayarClassExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHiz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbRam = new System.Windows.Forms.ComboBox();
            this.cbSuSogutma = new System.Windows.Forms.CheckBox();
            this.dtpUretimTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnGoster = new System.Windows.Forms.Button();
            this.lSonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // tbMarka
            // 
            this.tbMarka.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMarka.Location = new System.Drawing.Point(84, 38);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(100, 26);
            this.tbMarka.TabIndex = 3;
            this.tbMarka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbAciklama
            // 
            this.tbAciklama.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAciklama.Location = new System.Drawing.Point(84, 70);
            this.tbAciklama.Multiline = true;
            this.tbAciklama.Name = "tbAciklama";
            this.tbAciklama.Size = new System.Drawing.Size(100, 40);
            this.tbAciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(223, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 62);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "Bilgisayar Objesini Oluştur";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(84, 9);
            this.nudId.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(100, 23);
            this.nudId.TabIndex = 7;
            this.nudId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hız";
            // 
            // tbHiz
            // 
            this.tbHiz.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbHiz.Location = new System.Drawing.Point(84, 115);
            this.tbHiz.Name = "tbHiz";
            this.tbHiz.Size = new System.Drawing.Size(100, 26);
            this.tbHiz.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(12, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "RAM";
            // 
            // cbRam
            // 
            this.cbRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRam.FormattingEnabled = true;
            this.cbRam.Items.AddRange(new object[] {
            "8 GB",
            "16 GB",
            "32 GB"});
            this.cbRam.Location = new System.Drawing.Point(84, 150);
            this.cbRam.Name = "cbRam";
            this.cbRam.Size = new System.Drawing.Size(100, 23);
            this.cbRam.TabIndex = 11;
            // 
            // cbSuSogutma
            // 
            this.cbSuSogutma.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbSuSogutma.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSuSogutma.ForeColor = System.Drawing.Color.DarkRed;
            this.cbSuSogutma.Location = new System.Drawing.Point(12, 179);
            this.cbSuSogutma.Name = "cbSuSogutma";
            this.cbSuSogutma.Size = new System.Drawing.Size(138, 24);
            this.cbSuSogutma.TabIndex = 12;
            this.cbSuSogutma.Text = "Su Soğutma";
            this.cbSuSogutma.UseVisualStyleBackColor = true;
            // 
            // dtpUretimTarihi
            // 
            this.dtpUretimTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUretimTarihi.Location = new System.Drawing.Point(223, 180);
            this.dtpUretimTarihi.Name = "dtpUretimTarihi";
            this.dtpUretimTarihi.Size = new System.Drawing.Size(200, 23);
            this.dtpUretimTarihi.TabIndex = 13;
            // 
            // btnGoster
            // 
            this.btnGoster.Enabled = false;
            this.btnGoster.Location = new System.Drawing.Point(223, 70);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(97, 62);
            this.btnGoster.TabIndex = 6;
            this.btnGoster.Text = "Bilgisayar Objesini Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lSonuc
            // 
            this.lSonuc.AutoSize = true;
            this.lSonuc.Location = new System.Drawing.Point(19, 214);
            this.lSonuc.Name = "lSonuc";
            this.lSonuc.Size = new System.Drawing.Size(38, 15);
            this.lSonuc.TabIndex = 14;
            this.lSonuc.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(456, 243);
            this.Controls.Add(this.lSonuc);
            this.Controls.Add(this.dtpUretimTarihi);
            this.Controls.Add(this.cbSuSogutma);
            this.Controls.Add(this.cbRam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbHiz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbMarka;
        private Label label2;
        private TextBox tbAciklama;
        private Label label3;
        private Button btn1;
        private NumericUpDown nudId;
        private Label label4;
        private TextBox tbHiz;
        private Label label6;
        private ComboBox cbRam;
        private CheckBox cbSuSogutma;
        private DateTimePicker dtpUretimTarihi;
        private Button btnGoster;
        private Label lSonuc;
    }
}
namespace TestWin_Mariyana
{
    partial class Form1
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
            this.crbKorica = new System.Windows.Forms.GroupBox();
            this.grb2Janr = new System.Windows.Forms.GroupBox();
            this.ckb1 = new System.Windows.Forms.CheckBox();
            this.rb1Hudojestvena = new System.Windows.Forms.RadioButton();
            this.rb2NPop = new System.Windows.Forms.RadioButton();
            this.rb3Spravochna = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btn1Otpechatvane = new System.Windows.Forms.Button();
            this.crbKorica.SuspendLayout();
            this.grb2Janr.SuspendLayout();
            this.SuspendLayout();
            // 
            // crbKorica
            // 
            this.crbKorica.Controls.Add(this.ckb1);
            this.crbKorica.Location = new System.Drawing.Point(12, 101);
            this.crbKorica.Name = "crbKorica";
            this.crbKorica.Size = new System.Drawing.Size(200, 100);
            this.crbKorica.TabIndex = 0;
            this.crbKorica.TabStop = false;
            this.crbKorica.Text = "Корица";
            // 
            // grb2Janr
            // 
            this.grb2Janr.Controls.Add(this.rb3Spravochna);
            this.grb2Janr.Controls.Add(this.rb2NPop);
            this.grb2Janr.Controls.Add(this.rb1Hudojestvena);
            this.grb2Janr.Location = new System.Drawing.Point(12, 216);
            this.grb2Janr.Name = "grb2Janr";
            this.grb2Janr.Size = new System.Drawing.Size(185, 100);
            this.grb2Janr.TabIndex = 1;
            this.grb2Janr.TabStop = false;
            this.grb2Janr.Text = "Жанр";
            // 
            // ckb1
            // 
            this.ckb1.AutoSize = true;
            this.ckb1.Location = new System.Drawing.Point(7, 38);
            this.ckb1.Name = "ckb1";
            this.ckb1.Size = new System.Drawing.Size(63, 20);
            this.ckb1.TabIndex = 0;
            this.ckb1.Text = "Мека";
            this.ckb1.UseVisualStyleBackColor = true;
            // 
            // rb1Hudojestvena
            // 
            this.rb1Hudojestvena.AutoSize = true;
            this.rb1Hudojestvena.Location = new System.Drawing.Point(7, 21);
            this.rb1Hudojestvena.Name = "rb1Hudojestvena";
            this.rb1Hudojestvena.Size = new System.Drawing.Size(123, 20);
            this.rb1Hudojestvena.TabIndex = 0;
            this.rb1Hudojestvena.TabStop = true;
            this.rb1Hudojestvena.Text = "Художествена";
            this.rb1Hudojestvena.UseVisualStyleBackColor = true;
            // 
            // rb2NPop
            // 
            this.rb2NPop.AutoSize = true;
            this.rb2NPop.Location = new System.Drawing.Point(7, 49);
            this.rb2NPop.Name = "rb2NPop";
            this.rb2NPop.Size = new System.Drawing.Size(153, 20);
            this.rb2NPop.TabIndex = 1;
            this.rb2NPop.TabStop = true;
            this.rb2NPop.Text = "Научно-популярна";
            this.rb2NPop.UseVisualStyleBackColor = true;
            // 
            // rb3Spravochna
            // 
            this.rb3Spravochna.AutoSize = true;
            this.rb3Spravochna.Location = new System.Drawing.Point(7, 79);
            this.rb3Spravochna.Name = "rb3Spravochna";
            this.rb3Spravochna.Size = new System.Drawing.Size(101, 20);
            this.rb3Spravochna.TabIndex = 2;
            this.rb3Spravochna.TabStop = true;
            this.rb3Spravochna.Text = "Справочна";
            this.rb3Spravochna.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(51, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(47, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Автор";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(28, 48);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(70, 16);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Заглавие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "\"Осло\"",
            "\"Пан\"",
            "\"Лист\"",
            "\"Хистореон\""});
            this.cmb1.Location = new System.Drawing.Point(102, 71);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 24);
            this.cmb1.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(2, 79);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(94, 16);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Издателство";
            // 
            // btn1Otpechatvane
            // 
            this.btn1Otpechatvane.Location = new System.Drawing.Point(31, 334);
            this.btn1Otpechatvane.Name = "btn1Otpechatvane";
            this.btn1Otpechatvane.Size = new System.Drawing.Size(128, 51);
            this.btn1Otpechatvane.TabIndex = 8;
            this.btn1Otpechatvane.Text = "Отпечатване";
            this.btn1Otpechatvane.UseVisualStyleBackColor = true;
            this.btn1Otpechatvane.Click += new System.EventHandler(this.btn1Otpechatvane_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(252, 450);
            this.Controls.Add(this.btn1Otpechatvane);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.grb2Janr);
            this.Controls.Add(this.crbKorica);
            this.Name = "Form1";
            this.Text = "Книжарница";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.crbKorica.ResumeLayout(false);
            this.crbKorica.PerformLayout();
            this.grb2Janr.ResumeLayout(false);
            this.grb2Janr.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox crbKorica;
        private System.Windows.Forms.CheckBox ckb1;
        private System.Windows.Forms.GroupBox grb2Janr;
        private System.Windows.Forms.RadioButton rb3Spravochna;
        private System.Windows.Forms.RadioButton rb2NPop;
        private System.Windows.Forms.RadioButton rb1Hudojestvena;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btn1Otpechatvane;
    }
}


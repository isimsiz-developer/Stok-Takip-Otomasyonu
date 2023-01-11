namespace WindowsFormsApp13
{
    partial class sıfre_yenıle
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ysıfre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ysıfre2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kadı = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre Yenile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kod:";
            // 
            // tek
            // 
            this.tek.Location = new System.Drawing.Point(113, 117);
            this.tek.Name = "tek";
            this.tek.Size = new System.Drawing.Size(100, 22);
            this.tek.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Yeni Şifre:";
            // 
            // ysıfre
            // 
            this.ysıfre.Location = new System.Drawing.Point(113, 156);
            this.ysıfre.Name = "ysıfre";
            this.ysıfre.PasswordChar = '*';
            this.ysıfre.Size = new System.Drawing.Size(100, 22);
            this.ysıfre.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Yeni Şifre Tekrar:";
            // 
            // ysıfre2
            // 
            this.ysıfre2.Location = new System.Drawing.Point(113, 206);
            this.ysıfre2.Name = "ysıfre2";
            this.ysıfre2.PasswordChar = '*';
            this.ysıfre2.Size = new System.Drawing.Size(100, 22);
            this.ysıfre2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "şifre dğiştir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(90, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "şifreyi göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kullanıcı adı:";
            // 
            // kadı
            // 
            this.kadı.Location = new System.Drawing.Point(113, 82);
            this.kadı.Name = "kadı";
            this.kadı.Size = new System.Drawing.Size(100, 22);
            this.kadı.TabIndex = 6;
            // 
            // sıfre_yenıle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 466);
            this.Controls.Add(this.kadı);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ysıfre2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ysıfre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "sıfre_yenıle";
            this.Text = "Şifre Yenileme";
            this.Load += new System.EventHandler(this.sıfre_yenıle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ysıfre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ysıfre2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kadı;
    }
}
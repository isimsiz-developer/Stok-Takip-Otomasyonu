namespace WindowsFormsApp13
{
    partial class İade
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.barkod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.aded = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fiya = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fiş = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.öde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(372, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // barkod
            // 
            this.barkod.Location = new System.Drawing.Point(531, 69);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(197, 22);
            this.barkod.TabIndex = 1;
            this.barkod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "İade Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(531, 103);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(197, 22);
            this.ad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Adı:";
            // 
            // aded
            // 
            this.aded.Location = new System.Drawing.Point(531, 144);
            this.aded.Name = "aded";
            this.aded.Size = new System.Drawing.Size(197, 22);
            this.aded.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyat:";
            // 
            // fiya
            // 
            this.fiya.Location = new System.Drawing.Point(531, 190);
            this.fiya.Name = "fiya";
            this.fiya.Size = new System.Drawing.Size(197, 22);
            this.fiya.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "İade Adet:";
            // 
            // fiş
            // 
            this.fiş.Location = new System.Drawing.Point(531, 29);
            this.fiş.Name = "fiş";
            this.fiş.Size = new System.Drawing.Size(197, 22);
            this.fiş.TabIndex = 1;
            this.fiş.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fiş No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ödenecek Tutar:";
            // 
            // öde
            // 
            this.öde.AutoSize = true;
            this.öde.Location = new System.Drawing.Point(587, 360);
            this.öde.Name = "öde";
            this.öde.Size = new System.Drawing.Size(0, 16);
            this.öde.TabIndex = 4;
            // 
            // İade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp13.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.öde);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fiya);
            this.Controls.Add(this.aded);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.fiş);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "İade";
            this.Text = "İade";
            this.Load += new System.EventHandler(this.İade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fiya;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fiş;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label öde;
    }
}
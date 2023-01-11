namespace WindowsFormsApp13
{
    partial class satıs
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.satış = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aded = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toplam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fiş = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView2.Location = new System.Drawing.Point(293, 0);
            this.dataGridView2.MinimumSize = new System.Drawing.Size(1500, 400);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1500, 716);
            this.dataGridView2.TabIndex = 1;
            // 
            // satış
            // 
            this.satış.Location = new System.Drawing.Point(39, 582);
            this.satış.Name = "satış";
            this.satış.Size = new System.Drawing.Size(202, 32);
            this.satış.TabIndex = 2;
            this.satış.Text = "Satış Yap";
            this.satış.UseVisualStyleBackColor = true;
            this.satış.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "ürün kodu:";
            // 
            // barkod
            // 
            this.barkod.Location = new System.Drawing.Point(85, 210);
            this.barkod.Multiline = true;
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(202, 32);
            this.barkod.TabIndex = 4;
            this.barkod.TextChanged += new System.EventHandler(this.barkod_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(9, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Adı:";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(85, 267);
            this.ad.Multiline = true;
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(202, 32);
            this.ad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adet:";
            // 
            // aded
            // 
            this.aded.Location = new System.Drawing.Point(85, 329);
            this.aded.Multiline = true;
            this.aded.Name = "aded";
            this.aded.Size = new System.Drawing.Size(202, 32);
            this.aded.TabIndex = 4;
            this.aded.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Toplam:";
            // 
            // toplam
            // 
            this.toplam.Location = new System.Drawing.Point(85, 446);
            this.toplam.Multiline = true;
            this.toplam.Name = "toplam";
            this.toplam.Size = new System.Drawing.Size(202, 32);
            this.toplam.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(-2, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Fiyat:";
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(85, 389);
            this.fiyat.Multiline = true;
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(202, 32);
            this.fiyat.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "İade Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(15, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fiş No:";
            // 
            // fiş
            // 
            this.fiş.Location = new System.Drawing.Point(85, 505);
            this.fiş.Multiline = true;
            this.fiş.Name = "fiş";
            this.fiş.Size = new System.Drawing.Size(202, 32);
            this.fiş.TabIndex = 4;
            // 
            // satıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 716);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fiş);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.satış);
            this.Controls.Add(this.dataGridView2);
            this.Name = "satıs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "satıs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.satıs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button satış;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fiş;
    }
}
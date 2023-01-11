namespace WindowsFormsApp13
{
    partial class alınacaklar_oluştur
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
            this.goster = new System.Windows.Forms.DataGridView();
            this.oluştur = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.goster)).BeginInit();
            this.SuspendLayout();
            // 
            // goster
            // 
            this.goster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goster.Location = new System.Drawing.Point(12, 9);
            this.goster.Name = "goster";
            this.goster.RowHeadersWidth = 51;
            this.goster.RowTemplate.Height = 24;
            this.goster.Size = new System.Drawing.Size(780, 388);
            this.goster.TabIndex = 0;
            // 
            // oluştur
            // 
            this.oluştur.Location = new System.Drawing.Point(309, 403);
            this.oluştur.Name = "oluştur";
            this.oluştur.Size = new System.Drawing.Size(80, 35);
            this.oluştur.TabIndex = 1;
            this.oluştur.Text = "Oluştur";
            this.oluştur.UseVisualStyleBackColor = true;
            this.oluştur.Click += new System.EventHandler(this.oluştur_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // alınacaklar_oluştur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp13.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oluştur);
            this.Controls.Add(this.goster);
            this.DoubleBuffered = true;
            this.Name = "alınacaklar_oluştur";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Alınacaklar Oluştur";
            this.Load += new System.EventHandler(this.alınacaklar_oluştur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView goster;
        private System.Windows.Forms.Button oluştur;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
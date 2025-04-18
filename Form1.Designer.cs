namespace OdevSeri
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnJsonOku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Sienna;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(207, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 212);
            this.listBox1.TabIndex = 0;
            // 
            // BtnJsonOku
            // 
            this.BtnJsonOku.BackColor = System.Drawing.Color.RosyBrown;
            this.BtnJsonOku.Location = new System.Drawing.Point(297, 299);
            this.BtnJsonOku.Name = "BtnJsonOku";
            this.BtnJsonOku.Size = new System.Drawing.Size(114, 59);
            this.BtnJsonOku.TabIndex = 1;
            this.BtnJsonOku.Text = "Json Oku";
            this.BtnJsonOku.UseVisualStyleBackColor = false;
            this.BtnJsonOku.Click += new System.EventHandler(this.BtnJsonOku_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnJsonOku);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "JSONUGETİR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnJsonOku;
    }
}


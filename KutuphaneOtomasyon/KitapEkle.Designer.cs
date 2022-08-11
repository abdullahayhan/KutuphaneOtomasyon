
namespace KutuphaneOtomasyon
{
    partial class KitapEkle
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
            this.btn_kitapEkle = new System.Windows.Forms.Button();
            this.txt_KitapYazari = new System.Windows.Forms.TextBox();
            this.txt_KitapIsmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KitapSayfa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_BarkodNo = new System.Windows.Forms.TextBox();
            this.cmb_KitapTuru = new System.Windows.Forms.ComboBox();
            this.dateTime_kitap = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_kitapEkle
            // 
            this.btn_kitapEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_kitapEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_kitapEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_kitapEkle.Location = new System.Drawing.Point(20, 432);
            this.btn_kitapEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_kitapEkle.Name = "btn_kitapEkle";
            this.btn_kitapEkle.Size = new System.Drawing.Size(248, 41);
            this.btn_kitapEkle.TabIndex = 11;
            this.btn_kitapEkle.Text = "Ekle";
            this.btn_kitapEkle.UseVisualStyleBackColor = false;
            this.btn_kitapEkle.Click += new System.EventHandler(this.kitapEkle_btn_Click);
            // 
            // txt_KitapYazari
            // 
            this.txt_KitapYazari.Location = new System.Drawing.Point(72, 179);
            this.txt_KitapYazari.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapYazari.Multiline = true;
            this.txt_KitapYazari.Name = "txt_KitapYazari";
            this.txt_KitapYazari.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapYazari.TabIndex = 8;
            // 
            // txt_KitapIsmi
            // 
            this.txt_KitapIsmi.Location = new System.Drawing.Point(72, 112);
            this.txt_KitapIsmi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapIsmi.Multiline = true;
            this.txt_KitapIsmi.Name = "txt_KitapIsmi";
            this.txt_KitapIsmi.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapIsmi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(14, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kitap Türü :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kitap Baskı Tarihi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(20, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Kitap İsmi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(20, 361);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Kitap Sayfa Sayısı :";
            // 
            // txt_KitapSayfa
            // 
            this.txt_KitapSayfa.Location = new System.Drawing.Point(72, 390);
            this.txt_KitapSayfa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapSayfa.Multiline = true;
            this.txt_KitapSayfa.Name = "txt_KitapSayfa";
            this.txt_KitapSayfa.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapSayfa.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Barkod Numarası :";
            // 
            // txt_BarkodNo
            // 
            this.txt_BarkodNo.Location = new System.Drawing.Point(72, 47);
            this.txt_BarkodNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_BarkodNo.Multiline = true;
            this.txt_BarkodNo.Name = "txt_BarkodNo";
            this.txt_BarkodNo.Size = new System.Drawing.Size(156, 24);
            this.txt_BarkodNo.TabIndex = 10;
            // 
            // cmb_KitapTuru
            // 
            this.cmb_KitapTuru.FormattingEnabled = true;
            this.cmb_KitapTuru.Location = new System.Drawing.Point(72, 319);
            this.cmb_KitapTuru.Name = "cmb_KitapTuru";
            this.cmb_KitapTuru.Size = new System.Drawing.Size(156, 28);
            this.cmb_KitapTuru.TabIndex = 12;
            // 
            // dateTime_kitap
            // 
            this.dateTime_kitap.Location = new System.Drawing.Point(72, 245);
            this.dateTime_kitap.Name = "dateTime_kitap";
            this.dateTime_kitap.Size = new System.Drawing.Size(158, 27);
            this.dateTime_kitap.TabIndex = 13;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(286, 487);
            this.Controls.Add(this.dateTime_kitap);
            this.Controls.Add(this.cmb_KitapTuru);
            this.Controls.Add(this.btn_kitapEkle);
            this.Controls.Add(this.txt_KitapSayfa);
            this.Controls.Add(this.txt_KitapYazari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_BarkodNo);
            this.Controls.Add(this.txt_KitapIsmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KitapEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Ekleme";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitapEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_KitapYazari;
        public System.Windows.Forms.TextBox txt_KitapIsmi;
        public System.Windows.Forms.TextBox txt_KitapSayfa;
        public System.Windows.Forms.TextBox txt_BarkodNo;
        public System.Windows.Forms.ComboBox cmb_KitapTuru;
        private System.Windows.Forms.DateTimePicker dateTime_kitap;
    }
}
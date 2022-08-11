
namespace KutuphaneOtomasyon
{
    partial class KitapEmanetAl
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
            this.cmb_AlinabilirKitaplar = new System.Windows.Forms.ComboBox();
            this.dateTime_kitap = new System.Windows.Forms.DateTimePicker();
            this.cmb_KitapTuru = new System.Windows.Forms.ComboBox();
            this.txt_KitapSayfa = new System.Windows.Forms.TextBox();
            this.txt_KitapYazari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KitapIsmi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EmanetAl = new System.Windows.Forms.Button();
            this.txt_AranacakKitap = new System.Windows.Forms.TextBox();
            this.lbl_AranacakKitap = new System.Windows.Forms.Label();
            this.dataGridAlinabilirKitap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlinabilirKitap)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_AlinabilirKitaplar
            // 
            this.cmb_AlinabilirKitaplar.FormattingEnabled = true;
            this.cmb_AlinabilirKitaplar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_AlinabilirKitaplar.Location = new System.Drawing.Point(29, 101);
            this.cmb_AlinabilirKitaplar.Name = "cmb_AlinabilirKitaplar";
            this.cmb_AlinabilirKitaplar.Size = new System.Drawing.Size(156, 28);
            this.cmb_AlinabilirKitaplar.TabIndex = 0;
            this.cmb_AlinabilirKitaplar.SelectedIndexChanged += new System.EventHandler(this.cmb_AlinabilirKitaplar_SelectedIndexChanged);
            // 
            // dateTime_kitap
            // 
            this.dateTime_kitap.Enabled = false;
            this.dateTime_kitap.Location = new System.Drawing.Point(29, 180);
            this.dateTime_kitap.Name = "dateTime_kitap";
            this.dateTime_kitap.Size = new System.Drawing.Size(156, 27);
            this.dateTime_kitap.TabIndex = 25;
            // 
            // cmb_KitapTuru
            // 
            this.cmb_KitapTuru.Enabled = false;
            this.cmb_KitapTuru.FormattingEnabled = true;
            this.cmb_KitapTuru.Location = new System.Drawing.Point(261, 183);
            this.cmb_KitapTuru.Name = "cmb_KitapTuru";
            this.cmb_KitapTuru.Size = new System.Drawing.Size(156, 28);
            this.cmb_KitapTuru.TabIndex = 24;
            // 
            // txt_KitapSayfa
            // 
            this.txt_KitapSayfa.Enabled = false;
            this.txt_KitapSayfa.Location = new System.Drawing.Point(517, 181);
            this.txt_KitapSayfa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapSayfa.Multiline = true;
            this.txt_KitapSayfa.Name = "txt_KitapSayfa";
            this.txt_KitapSayfa.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapSayfa.TabIndex = 20;
            // 
            // txt_KitapYazari
            // 
            this.txt_KitapYazari.Enabled = false;
            this.txt_KitapYazari.Location = new System.Drawing.Point(517, 105);
            this.txt_KitapYazari.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapYazari.Multiline = true;
            this.txt_KitapYazari.Name = "txt_KitapYazari";
            this.txt_KitapYazari.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapYazari.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(488, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Kitap Sayfa Sayısı :";
            // 
            // txt_KitapIsmi
            // 
            this.txt_KitapIsmi.Enabled = false;
            this.txt_KitapIsmi.Location = new System.Drawing.Point(261, 105);
            this.txt_KitapIsmi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_KitapIsmi.Multiline = true;
            this.txt_KitapIsmi.Name = "txt_KitapIsmi";
            this.txt_KitapIsmi.Size = new System.Drawing.Size(156, 24);
            this.txt_KitapIsmi.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(241, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kitap Türü :";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(488, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 16;
            this.label2.Text = "Kitap Yazarı :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitap Baskı Tarihi :";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(14, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 29);
            this.label6.TabIndex = 18;
            this.label6.Text = "Barkod Numarası";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(241, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Kitap İsmi :";
            // 
            // btn_EmanetAl
            // 
            this.btn_EmanetAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EmanetAl.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_EmanetAl.Location = new System.Drawing.Point(241, 244);
            this.btn_EmanetAl.Name = "btn_EmanetAl";
            this.btn_EmanetAl.Size = new System.Drawing.Size(229, 42);
            this.btn_EmanetAl.TabIndex = 26;
            this.btn_EmanetAl.Text = "Kitap Emanet Al";
            this.btn_EmanetAl.UseVisualStyleBackColor = true;
            this.btn_EmanetAl.Click += new System.EventHandler(this.btn_EmanetAl_Click);
            // 
            // txt_AranacakKitap
            // 
            this.txt_AranacakKitap.Location = new System.Drawing.Point(357, 22);
            this.txt_AranacakKitap.Name = "txt_AranacakKitap";
            this.txt_AranacakKitap.Size = new System.Drawing.Size(156, 27);
            this.txt_AranacakKitap.TabIndex = 27;
            this.txt_AranacakKitap.TextChanged += new System.EventHandler(this.txt_AranacakKitap_TextChanged);
            // 
            // lbl_AranacakKitap
            // 
            this.lbl_AranacakKitap.AutoSize = true;
            this.lbl_AranacakKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AranacakKitap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AranacakKitap.Location = new System.Drawing.Point(63, 20);
            this.lbl_AranacakKitap.Name = "lbl_AranacakKitap";
            this.lbl_AranacakKitap.Size = new System.Drawing.Size(274, 29);
            this.lbl_AranacakKitap.TabIndex = 28;
            this.lbl_AranacakKitap.Text = "Aranacak Kitap İsmi :";
            // 
            // dataGridAlinabilirKitap
            // 
            this.dataGridAlinabilirKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAlinabilirKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlinabilirKitap.Location = new System.Drawing.Point(29, 308);
            this.dataGridAlinabilirKitap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridAlinabilirKitap.MultiSelect = false;
            this.dataGridAlinabilirKitap.Name = "dataGridAlinabilirKitap";
            this.dataGridAlinabilirKitap.RowHeadersVisible = false;
            this.dataGridAlinabilirKitap.RowHeadersWidth = 51;
            this.dataGridAlinabilirKitap.RowTemplate.Height = 24;
            this.dataGridAlinabilirKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAlinabilirKitap.Size = new System.Drawing.Size(669, 218);
            this.dataGridAlinabilirKitap.TabIndex = 29;
            this.dataGridAlinabilirKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAlinabilirKitap_CellClick);
            // 
            // KitapEmanetAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(718, 536);
            this.Controls.Add(this.dataGridAlinabilirKitap);
            this.Controls.Add(this.lbl_AranacakKitap);
            this.Controls.Add(this.txt_AranacakKitap);
            this.Controls.Add(this.btn_EmanetAl);
            this.Controls.Add(this.dateTime_kitap);
            this.Controls.Add(this.cmb_KitapTuru);
            this.Controls.Add(this.txt_KitapSayfa);
            this.Controls.Add(this.txt_KitapYazari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_KitapIsmi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_AlinabilirKitaplar);
            this.Name = "KitapEmanetAl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap Emanet Al";
            this.Load += new System.EventHandler(this.KitapEmanetAl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlinabilirKitap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_AlinabilirKitaplar;
        private System.Windows.Forms.DateTimePicker dateTime_kitap;
        public System.Windows.Forms.ComboBox cmb_KitapTuru;
        public System.Windows.Forms.TextBox txt_KitapSayfa;
        public System.Windows.Forms.TextBox txt_KitapYazari;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_KitapIsmi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EmanetAl;
        private System.Windows.Forms.TextBox txt_AranacakKitap;
        private System.Windows.Forms.Label lbl_AranacakKitap;
        private System.Windows.Forms.DataGridView dataGridAlinabilirKitap;
    }
}
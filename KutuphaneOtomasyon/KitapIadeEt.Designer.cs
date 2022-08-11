
namespace KutuphaneOtomasyon
{
    partial class KitapIadeEt
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
            this.lbl_AranacakKitap = new System.Windows.Forms.Label();
            this.txt_AranacakKitap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_IadeEdilecekKitap = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_teslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtp_alinisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ucret = new System.Windows.Forms.Label();
            this.btn_iadeEt = new System.Windows.Forms.Button();
            this.dataGridIadeEdilebilecekKitaplar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIadeEdilebilecekKitaplar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AranacakKitap
            // 
            this.lbl_AranacakKitap.AutoSize = true;
            this.lbl_AranacakKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_AranacakKitap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AranacakKitap.Location = new System.Drawing.Point(31, 6);
            this.lbl_AranacakKitap.Name = "lbl_AranacakKitap";
            this.lbl_AranacakKitap.Size = new System.Drawing.Size(223, 20);
            this.lbl_AranacakKitap.TabIndex = 32;
            this.lbl_AranacakKitap.Text = "İade Edilecek Kitap İsmi :";
            // 
            // txt_AranacakKitap
            // 
            this.txt_AranacakKitap.Location = new System.Drawing.Point(47, 32);
            this.txt_AranacakKitap.Name = "txt_AranacakKitap";
            this.txt_AranacakKitap.Size = new System.Drawing.Size(209, 27);
            this.txt_AranacakKitap.TabIndex = 31;
            this.txt_AranacakKitap.TextChanged += new System.EventHandler(this.txt_AranacakKitap_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(302, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Barkod Numarası:";
            // 
            // cmb_IadeEdilecekKitap
            // 
            this.cmb_IadeEdilecekKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IadeEdilecekKitap.Enabled = false;
            this.cmb_IadeEdilecekKitap.FormattingEnabled = true;
            this.cmb_IadeEdilecekKitap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_IadeEdilecekKitap.Location = new System.Drawing.Point(325, 31);
            this.cmb_IadeEdilecekKitap.Name = "cmb_IadeEdilecekKitap";
            this.cmb_IadeEdilecekKitap.Size = new System.Drawing.Size(209, 28);
            this.cmb_IadeEdilecekKitap.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kitap Alınış Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(302, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Kitap Son Teslim Tarihi :";
            // 
            // dtp_teslimTarihi
            // 
            this.dtp_teslimTarihi.Enabled = false;
            this.dtp_teslimTarihi.Location = new System.Drawing.Point(318, 98);
            this.dtp_teslimTarihi.Name = "dtp_teslimTarihi";
            this.dtp_teslimTarihi.Size = new System.Drawing.Size(209, 27);
            this.dtp_teslimTarihi.TabIndex = 34;
            // 
            // dtp_alinisTarihi
            // 
            this.dtp_alinisTarihi.Enabled = false;
            this.dtp_alinisTarihi.Location = new System.Drawing.Point(47, 98);
            this.dtp_alinisTarihi.Name = "dtp_alinisTarihi";
            this.dtp_alinisTarihi.Size = new System.Drawing.Size(209, 27);
            this.dtp_alinisTarihi.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(209, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ücret :";
            // 
            // lbl_ucret
            // 
            this.lbl_ucret.AutoSize = true;
            this.lbl_ucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ucret.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ucret.Location = new System.Drawing.Point(323, 150);
            this.lbl_ucret.Name = "lbl_ucret";
            this.lbl_ucret.Size = new System.Drawing.Size(37, 29);
            this.lbl_ucret.TabIndex = 33;
            this.lbl_ucret.Text = "...";
            // 
            // btn_iadeEt
            // 
            this.btn_iadeEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_iadeEt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_iadeEt.Location = new System.Drawing.Point(186, 205);
            this.btn_iadeEt.Name = "btn_iadeEt";
            this.btn_iadeEt.Size = new System.Drawing.Size(209, 36);
            this.btn_iadeEt.TabIndex = 35;
            this.btn_iadeEt.Text = "İade Et";
            this.btn_iadeEt.UseVisualStyleBackColor = true;
            this.btn_iadeEt.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridIadeEdilebilecekKitaplar
            // 
            this.dataGridIadeEdilebilecekKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridIadeEdilebilecekKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIadeEdilebilecekKitaplar.Location = new System.Drawing.Point(19, 258);
            this.dataGridIadeEdilebilecekKitaplar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridIadeEdilebilecekKitaplar.MultiSelect = false;
            this.dataGridIadeEdilebilecekKitaplar.Name = "dataGridIadeEdilebilecekKitaplar";
            this.dataGridIadeEdilebilecekKitaplar.RowHeadersVisible = false;
            this.dataGridIadeEdilebilecekKitaplar.RowHeadersWidth = 51;
            this.dataGridIadeEdilebilecekKitaplar.RowTemplate.Height = 24;
            this.dataGridIadeEdilebilecekKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIadeEdilebilecekKitaplar.Size = new System.Drawing.Size(548, 171);
            this.dataGridIadeEdilebilecekKitaplar.TabIndex = 36;
            this.dataGridIadeEdilebilecekKitaplar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridIadeEdilebilecekKitaplar_CellClick);
            // 
            // KitapIadeEt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(585, 441);
            this.Controls.Add(this.dataGridIadeEdilebilecekKitaplar);
            this.Controls.Add(this.btn_iadeEt);
            this.Controls.Add(this.dtp_alinisTarihi);
            this.Controls.Add(this.dtp_teslimTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_ucret);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_AranacakKitap);
            this.Controls.Add(this.txt_AranacakKitap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_IadeEdilecekKitap);
            this.Name = "KitapIadeEt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kitap İade Et";
            this.Load += new System.EventHandler(this.KitapIadeEt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIadeEdilebilecekKitaplar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AranacakKitap;
        private System.Windows.Forms.TextBox txt_AranacakKitap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_IadeEdilecekKitap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_teslimTarihi;
        private System.Windows.Forms.DateTimePicker dtp_alinisTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ucret;
        private System.Windows.Forms.Button btn_iadeEt;
        private System.Windows.Forms.DataGridView dataGridIadeEdilebilecekKitaplar;
    }
}
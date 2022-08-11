
namespace KutuphaneOtomasyon
{
    partial class AnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.OgrenciEkle_btn = new System.Windows.Forms.Button();
            this.OgrenciGuncelleme_btn = new System.Windows.Forms.Button();
            this.OgrenciSilme_btn = new System.Windows.Forms.Button();
            this.KitapEkle_btn = new System.Windows.Forms.Button();
            this.KitapGuncelle_btn = new System.Windows.Forms.Button();
            this.KitapSil_btn = new System.Windows.Forms.Button();
            this.dataGridKitap = new System.Windows.Forms.DataGridView();
            this.btn_grafik = new System.Windows.Forms.Button();
            this.dataGridOgrenci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // OgrenciEkle_btn
            // 
            this.OgrenciEkle_btn.BackColor = System.Drawing.SystemColors.Window;
            this.OgrenciEkle_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OgrenciEkle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OgrenciEkle_btn.Image = ((System.Drawing.Image)(resources.GetObject("OgrenciEkle_btn.Image")));
            this.OgrenciEkle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OgrenciEkle_btn.Location = new System.Drawing.Point(0, 1);
            this.OgrenciEkle_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OgrenciEkle_btn.Name = "OgrenciEkle_btn";
            this.OgrenciEkle_btn.Size = new System.Drawing.Size(253, 112);
            this.OgrenciEkle_btn.TabIndex = 0;
            this.OgrenciEkle_btn.Text = "Öğrenci Ekleme";
            this.OgrenciEkle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OgrenciEkle_btn.UseVisualStyleBackColor = false;
            this.OgrenciEkle_btn.Click += new System.EventHandler(this.OgrenciEkle_btn_Click);
            // 
            // OgrenciGuncelleme_btn
            // 
            this.OgrenciGuncelleme_btn.BackColor = System.Drawing.SystemColors.Window;
            this.OgrenciGuncelleme_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OgrenciGuncelleme_btn.Image = ((System.Drawing.Image)(resources.GetObject("OgrenciGuncelleme_btn.Image")));
            this.OgrenciGuncelleme_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OgrenciGuncelleme_btn.Location = new System.Drawing.Point(247, 1);
            this.OgrenciGuncelleme_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OgrenciGuncelleme_btn.Name = "OgrenciGuncelleme_btn";
            this.OgrenciGuncelleme_btn.Size = new System.Drawing.Size(253, 112);
            this.OgrenciGuncelleme_btn.TabIndex = 0;
            this.OgrenciGuncelleme_btn.Text = "Öğrenci Güncelleme";
            this.OgrenciGuncelleme_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OgrenciGuncelleme_btn.UseVisualStyleBackColor = false;
            this.OgrenciGuncelleme_btn.Click += new System.EventHandler(this.OgrenciGuncelleme_btn_Click);
            // 
            // OgrenciSilme_btn
            // 
            this.OgrenciSilme_btn.BackColor = System.Drawing.SystemColors.Window;
            this.OgrenciSilme_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OgrenciSilme_btn.Image = ((System.Drawing.Image)(resources.GetObject("OgrenciSilme_btn.Image")));
            this.OgrenciSilme_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.OgrenciSilme_btn.Location = new System.Drawing.Point(494, 1);
            this.OgrenciSilme_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OgrenciSilme_btn.Name = "OgrenciSilme_btn";
            this.OgrenciSilme_btn.Size = new System.Drawing.Size(253, 112);
            this.OgrenciSilme_btn.TabIndex = 0;
            this.OgrenciSilme_btn.Text = "Öğrenci Silme";
            this.OgrenciSilme_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.OgrenciSilme_btn.UseVisualStyleBackColor = false;
            this.OgrenciSilme_btn.Click += new System.EventHandler(this.OgrenciSilme_btn_Click);
            // 
            // KitapEkle_btn
            // 
            this.KitapEkle_btn.BackColor = System.Drawing.SystemColors.Window;
            this.KitapEkle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitapEkle_btn.Image = ((System.Drawing.Image)(resources.GetObject("KitapEkle_btn.Image")));
            this.KitapEkle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KitapEkle_btn.Location = new System.Drawing.Point(741, 1);
            this.KitapEkle_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KitapEkle_btn.Name = "KitapEkle_btn";
            this.KitapEkle_btn.Size = new System.Drawing.Size(253, 112);
            this.KitapEkle_btn.TabIndex = 0;
            this.KitapEkle_btn.Text = "Kitap Ekleme";
            this.KitapEkle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KitapEkle_btn.UseVisualStyleBackColor = false;
            this.KitapEkle_btn.Click += new System.EventHandler(this.KitapEkle_btn_Click);
            // 
            // KitapGuncelle_btn
            // 
            this.KitapGuncelle_btn.BackColor = System.Drawing.SystemColors.Window;
            this.KitapGuncelle_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitapGuncelle_btn.Image = ((System.Drawing.Image)(resources.GetObject("KitapGuncelle_btn.Image")));
            this.KitapGuncelle_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KitapGuncelle_btn.Location = new System.Drawing.Point(985, 1);
            this.KitapGuncelle_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KitapGuncelle_btn.Name = "KitapGuncelle_btn";
            this.KitapGuncelle_btn.Size = new System.Drawing.Size(253, 112);
            this.KitapGuncelle_btn.TabIndex = 0;
            this.KitapGuncelle_btn.Text = "Kitap Güncelleme";
            this.KitapGuncelle_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KitapGuncelle_btn.UseVisualStyleBackColor = false;
            this.KitapGuncelle_btn.Click += new System.EventHandler(this.KitapGuncelle_btn_Click);
            // 
            // KitapSil_btn
            // 
            this.KitapSil_btn.BackColor = System.Drawing.SystemColors.Window;
            this.KitapSil_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KitapSil_btn.Image = ((System.Drawing.Image)(resources.GetObject("KitapSil_btn.Image")));
            this.KitapSil_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KitapSil_btn.Location = new System.Drawing.Point(1226, 1);
            this.KitapSil_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KitapSil_btn.Name = "KitapSil_btn";
            this.KitapSil_btn.Size = new System.Drawing.Size(253, 112);
            this.KitapSil_btn.TabIndex = 0;
            this.KitapSil_btn.Text = "Kitap Silme";
            this.KitapSil_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.KitapSil_btn.UseVisualStyleBackColor = false;
            this.KitapSil_btn.Click += new System.EventHandler(this.KitapSil_btn_Click);
            // 
            // dataGridKitap
            // 
            this.dataGridKitap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKitap.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridKitap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKitap.GridColor = System.Drawing.Color.Tan;
            this.dataGridKitap.Location = new System.Drawing.Point(811, 163);
            this.dataGridKitap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridKitap.MultiSelect = false;
            this.dataGridKitap.Name = "dataGridKitap";
            this.dataGridKitap.RowHeadersVisible = false;
            this.dataGridKitap.RowHeadersWidth = 51;
            this.dataGridKitap.RowTemplate.Height = 40;
            this.dataGridKitap.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKitap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKitap.Size = new System.Drawing.Size(829, 492);
            this.dataGridKitap.TabIndex = 1;
            this.dataGridKitap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKitap_CellClick);
            // 
            // btn_grafik
            // 
            this.btn_grafik.BackColor = System.Drawing.SystemColors.Window;
            this.btn_grafik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_grafik.Image = global::View.Properties.Resources._2169614_bar_chart_financial_graph_graphic_icon;
            this.btn_grafik.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_grafik.Location = new System.Drawing.Point(1472, 1);
            this.btn_grafik.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_grafik.Name = "btn_grafik";
            this.btn_grafik.Size = new System.Drawing.Size(168, 112);
            this.btn_grafik.TabIndex = 0;
            this.btn_grafik.Text = "Grafik";
            this.btn_grafik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_grafik.UseVisualStyleBackColor = false;
            this.btn_grafik.Click += new System.EventHandler(this.btn_grafik_Click);
            // 
            // dataGridOgrenci
            // 
            this.dataGridOgrenci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOgrenci.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOgrenci.GridColor = System.Drawing.Color.Tan;
            this.dataGridOgrenci.Location = new System.Drawing.Point(0, 163);
            this.dataGridOgrenci.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridOgrenci.MultiSelect = false;
            this.dataGridOgrenci.Name = "dataGridOgrenci";
            this.dataGridOgrenci.RowHeadersVisible = false;
            this.dataGridOgrenci.RowHeadersWidth = 51;
            this.dataGridOgrenci.RowTemplate.Height = 40;
            this.dataGridOgrenci.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridOgrenci.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridOgrenci.Size = new System.Drawing.Size(815, 492);
            this.dataGridOgrenci.TabIndex = 1;
            this.dataGridOgrenci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOgrenci_CellClick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1640, 652);
            this.Controls.Add(this.dataGridOgrenci);
            this.Controls.Add(this.dataGridKitap);
            this.Controls.Add(this.btn_grafik);
            this.Controls.Add(this.KitapSil_btn);
            this.Controls.Add(this.OgrenciSilme_btn);
            this.Controls.Add(this.KitapGuncelle_btn);
            this.Controls.Add(this.OgrenciGuncelleme_btn);
            this.Controls.Add(this.KitapEkle_btn);
            this.Controls.Add(this.OgrenciEkle_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyon";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKitap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOgrenci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OgrenciEkle_btn;
        private System.Windows.Forms.Button OgrenciGuncelleme_btn;
        private System.Windows.Forms.Button OgrenciSilme_btn;
        private System.Windows.Forms.Button KitapEkle_btn;
        private System.Windows.Forms.Button KitapGuncelle_btn;
        private System.Windows.Forms.Button KitapSil_btn;
        private System.Windows.Forms.DataGridView dataGridKitap;
        private System.Windows.Forms.Button btn_grafik;
        private System.Windows.Forms.DataGridView dataGridOgrenci;
    }
}


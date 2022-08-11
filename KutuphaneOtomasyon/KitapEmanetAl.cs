using Businesss;
using DTO.Concrete;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Veritabani.TablolarRepo;
namespace KutuphaneOtomasyon
{
    public partial class KitapEmanetAl : Form
    {
        Ogrenci IslemGorecekOgrenci;
        //öncekilerle aynı mantıkla burada da öğrenci tc yi parametre olarak alıp işlem görecek öğrenciye ulaşıyorum.
       public KitapEmanetAl(string ogrenciTC)
        {
            IslemGorecekOgrenci = Tablolar.Ogrenciler.GetByIdWithIslemler(ogrenciTC);
            InitializeComponent();
        }
        //alınabilir kitaplara tanımladığım metot ile ulaşıp kullanıcı neleri alabilir diye datagride kitap bilgilerini liste halinde işliyorum. sonrasında kitap türünü combobox a işliyorum. datagrid başlıklarını düzenliyorum.
        private void KitapEmanetAl_Load(object sender, EventArgs e)
        {
            var alinabilirKitap = Tablolar.Kitaplar.GetAvailableKitap();
            cmb_AlinabilirKitaplar.DataSource = Tablolar.Kitaplar.GetAvailableKitapBarkodNo().ToList();
            dataGridAlinabilirKitap.DataSource = alinabilirKitap.ToList();
            cmb_KitapTuru.DataSource = Enum.GetValues(typeof(KitapTuru));
            cmb_AlinabilirKitaplar.SelectedIndex = -1;
            dataGridAlinabilirKitap.KitapBaslik();
            dataGridAlinabilirKitap.Columns["KitapIslemler"].Visible = false;
        }
        //buradaki olay kullanıcı isterse barkod numarasına göre kitabı seçer isterse kitabın ismini aratır isterse de datagrid üzerinden istediği kitaba tıklayarak kitabı emanet alır. Burada barkod no ile istenilen kitaba ulaşıp bilgilerini ekrana yazdırma işlemini yaptım.
        private void cmb_AlinabilirKitaplar_SelectedIndexChanged(object sender, EventArgs e)
        {

            var secilenKitap = Tablolar.Kitaplar.GetById(cmb_AlinabilirKitaplar.Text);
            if (secilenKitap != null)
            {
                txt_KitapYazari.Text = secilenKitap.KitapYazari;
                txt_KitapSayfa.Text = secilenKitap.KitapSayfaSayisi.ToString();
                txt_KitapIsmi.Text = secilenKitap.KitapAdi;
                cmb_KitapTuru.SelectedItem = secilenKitap.KitapTuru;
                dateTime_kitap.Value = secilenKitap.KitapBaskiTarihi;
            }
            else
            {
                txt_KitapIsmi.Text = "";
                txt_KitapSayfa.Text = "";
                cmb_KitapTuru.SelectedIndex = -1;
                txt_KitapYazari.Text = "";
                dateTime_kitap.Value = DateTime.Now;
            }
        }
        //Burada da aranan kitabı ismine göre bulup bilgilerini ekrana yazdırdım.
        private void txt_AranacakKitap_TextChanged(object sender, EventArgs e)
        {
            var aratilankitap = Tablolar.Kitaplar.GetByName(txt_AranacakKitap.Text);
            if (aratilankitap != null)
			{
                var x = cmb_AlinabilirKitaplar.Items.IndexOf(aratilankitap.BarkodNo);
                cmb_AlinabilirKitaplar.SelectedIndex = x;
            }
                
            else cmb_AlinabilirKitaplar.SelectedIndex = -1;
        }
        //emanet al butonunda ise alınması istenen kitaba ulaşıp alınabilir mi propunu false yapıyorum ve kutuphane islemleri adında bir nesne oluşturup object initializer yöntemiyle içindeki bilgileri atıyorum.
        private void btn_EmanetAl_Click(object sender, EventArgs e)
        {
            var kitap = Tablolar.Kitaplar.GetById(cmb_AlinabilirKitaplar.Text);
            if (kitap!=null)
            {
                kitap.alinabilirMi = false;
                var islem = new KutuphaneIslemleri()
                {
                    KitapAlimTarihi = DateTime.Now,
                    KitapIadeTarihi = null,
                    OgrenciTC = IslemGorecekOgrenci.OgrenciTc,
                    KitapID = kitap.BarkodNo,
                    Ucret = 0,
                };
                Tablolar.Islemler.Add(islem);
                Tablolar.Kitaplar.Update(kitap);
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kitabı seçiniz veya isim ile aratınız.");
            }
        }
        // Burada da kullanıcı datagrid üzerinden kitap seçimi yaparsa diye gerekli kodları yazdım.
        private void dataGridAlinabilirKitap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_AranacakKitap.Text = dataGridAlinabilirKitap.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}

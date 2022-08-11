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

    public partial class KitapEkle : Form
    {
        public bool isUpdate;
        //burada kitap ekle ve güncelle için aynı form ekranını kullanıyorum aralarında ufak değişiklikler var sadece. O yüzden güncelleme mi yoksa ekleme mi olduğunu anlamak için consta paremetre veriyorum bu classın nesnesi oluştururken bir değer verilmez ise default olarak false alıyor.
        public KitapEkle(bool isUpdate=false)
        {

            this.isUpdate = isUpdate;
            InitializeComponent();
        }
        private void kitapEkle_btn_Click(object sender, EventArgs e)
        {
            //Burada kitap nesnesi oluşturup içini textboxtaki bilgiler ile dolduruyorum
            Kitap kitap = new Kitap()
            {
                BarkodNo = txt_BarkodNo.Text,
                KitapAdi = txt_KitapIsmi.Text,
                KitapYazari = txt_KitapYazari.Text,
                KitapBaskiTarihi = dateTime_kitap.Value,
                KitapSayfaSayisi = Convert.ToInt32(txt_KitapSayfa.Text),
                KitapTuru = (KitapTuru)cmb_KitapTuru.SelectedIndex
            };
            //güncelleme mi yoksa ekleme mi diye kontrol ettiriyorum güncellemeyse tablolardan kitaplara ulaşıp update diyip kitabı paremetre olarak veriyorum güncelleme değilse kitap kaydı var mı diye sorgu yaptırıyorum yoksa kaydediyorum varsa messagebox ile ekrana çıktı veriyorum.
            if (isUpdate)
            {
                //Kitabı güncellerken zimmetli olabilme ihtimali için veritabanına ulaşıp alinabilir mi propunu kitaba göre güncelliyoruz.
                kitap.alinabilirMi = Tablolar.Kitaplar.GetById(kitap.BarkodNo).alinabilirMi;
                Tablolar.Kitaplar.Update(kitap);
                MessageBox.Show("İşlem Başarılı");
            } else if (Tablolar.Kitaplar.GetById(kitap.BarkodNo) == null)
            {
                Tablolar.Kitaplar.Add(kitap);
                MessageBox.Show("İşlem Başarılı");
            } else MessageBox.Show("Kayıt zaten var.");
        
            this.Close();
        }

        //load olayına da enum tipinde olan kitap türünü atıyorum ve güncellemeyse barkod numarasının güncellenmesini istemediğim için textboxını ulaşılamaz yapıp formun textini güncelle olarak değiştiriyorum.
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            cmb_KitapTuru.DataSource=Enum.GetValues(typeof(KitapTuru));
            if (isUpdate)
            {
                txt_BarkodNo.Enabled = false;
                btn_kitapEkle.Text = "Güncelle";
            }
        }
    }
}

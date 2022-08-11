using Businesss;
using DTO.Concrete;
using Entitys.Models;
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
using Entity.Models;

namespace KutuphaneOtomasyon
{
    public partial class Profil : Form
    {
        Ogrenci ogrenci;
        Kitap kitap;
        List<KitapIslemBilgi> kitapIslemBilgi;
        List<OgrenciIslemBilgi> ogrenciIslemBilgi;

        public Profil(string islemGorecekID,string whichIslem)
        {
            if (whichIslem=="ogrenci")
            {
                this.ogrenci = Tablolar.Ogrenciler.GetByIdWithIslemler(islemGorecekID);
                this.ogrenciIslemBilgi = new List<OgrenciIslemBilgi>();
            }
            else if (whichIslem=="kitap")
            {
                this.kitap = Tablolar.Kitaplar.GetKitapByIdWithIslemler(islemGorecekID);
                this.kitapIslemBilgi = new List<KitapIslemBilgi>();
            }
            InitializeComponent();
        }

        private void Profil_Load(object sender, EventArgs e)
        {
            if (ogrenci != null)
            {
                lbl_id.Text = "Öğrenci TC :";
                lbl_isim.Text = "Öğrenci İsmi :";
                lbl_soyadOrYazar.Text = "Öğrenci Soyadı :";
                lbl_okulOrSayfa.Text = "Öğrenci Okulu :";
                txt_isim.Text = ogrenci.OgrenciAdi;
                txt_soyadOrYazar.Text = ogrenci.OgrenciSoyadi;
                txt_id.Text = ogrenci.OgrenciTc;
                txt_okulOrSayfa.Text = ogrenci.OgrenciOkul;
                foreach (var item in ogrenci.OgrenciIslemler)
                {
                    var x = new OgrenciIslemBilgi()
                    {
                        IslemID = item.IslemID,
                        KitapAdi = Tablolar.Kitaplar.GetById(item.KitapID).KitapAdi,
                        AlinmaTarihi = item.KitapAlimTarihi,
                        SonTeslimTarihi = item.KitapAlimTarihi.AddDays(15),
                        IadeTarihi = item.KitapIadeTarihi,
                        IslemCezasi = item.GetBorc()
                    };
                    ogrenciIslemBilgi.Add(x);
                }
                dataGrid_TumIslemler.DataSource = ogrenciIslemBilgi;
            }
            else if (kitap != null)
            {
                lbl_id.Text = "Barkod No :";
                lbl_isim.Text = "Kitap Adı :";
                lbl_soyadOrYazar.Text = "Kitap Yazarı :";
                lbl_okulOrSayfa.Text = "Sayfa Sayısı :";
                txt_id.Text = kitap.BarkodNo;
                txt_isim.Text = kitap.KitapAdi;
                txt_soyadOrYazar.Text = kitap.KitapYazari;
                txt_okulOrSayfa.Text = kitap.KitapSayfaSayisi.ToString();
                foreach (var item in kitap.KitapIslemler)
                {
                    var x = new KitapIslemBilgi()
                    {
                        IslemID = item.IslemID,
                        OgrenciAdi = Tablolar.Ogrenciler.GetById(item.OgrenciTC).OgrenciAdi,
                        AlinmaTarihi = item.KitapAlimTarihi,
                        SonTeslimTarihi = item.KitapAlimTarihi.AddDays(15),
                        IadeTarihi = item.KitapIadeTarihi,
                        IslemCezasi = item.GetBorc()
                    };
                    kitapIslemBilgi.Add(x);
                }
                dataGrid_TumIslemler.DataSource = kitapIslemBilgi;
            }
            dataGrid_TumIslemler.Boya();
            dataGrid_TumIslemler.ClearSelection();
            dataGrid_TumIslemler.DetayBaslik();
        }
    }
}

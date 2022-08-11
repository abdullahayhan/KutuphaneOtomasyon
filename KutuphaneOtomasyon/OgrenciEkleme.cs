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
    public partial class OgrenciEkleme : Form
    {
        public bool isUpdate;
        // bu form ekranı güncelleme mi yoksa ekleme mi olacak diye kontrol ettiriyorum Kitap eklemedeki aynı mantığı burada da kullandım.
        public OgrenciEkleme(bool isUpdate=false)
        {
            this.isUpdate = isUpdate;
            InitializeComponent();
        }
        private void ogrEkle_btn_Click(object sender, EventArgs e)
        {
          
            Ogrenci ogrenci = new Ogrenci()
            {
                OgrenciTc = txt_OgrenciTc.Text,
                OgrenciAdi = OgrenciAdi_txt.Text,
                OgrenciSoyadi = OgrenciSoyadi_txt.Text,
                OgrenciOkul = OgrenciOkul_txt.Text,
            };

            if (isUpdate)
            {
                Tablolar.Ogrenciler.Update(ogrenci);
                MessageBox.Show("Öğrenci Güncelleme İşlemi Başarılı");
            }
            else if (Tablolar.Ogrenciler.GetById(txt_OgrenciTc.Text) == null)
            {
                Tablolar.Ogrenciler.Add(ogrenci);
                MessageBox.Show("Öğrenci Ekleme İşlemi Başarılı");
            }
            else MessageBox.Show("Aynı tc kimlik no ile başka öğrenci kayıtlı.");
            this.Close();
        }

        private void OgrenciEkleme_Load(object sender, EventArgs e)
        {
            if (isUpdate)
            {
                txt_OgrenciTc.Enabled = false;
                btn_ogrEkle.Text = "Güncelle";
            }
        }
    }
}

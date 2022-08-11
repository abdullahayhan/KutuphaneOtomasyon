using Businesss;
using DTO.Concrete;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using Microsoft.EntityFrameworkCore;
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
    public partial class KitapIadeEt : Form
    {
        Ogrenci IslemGorecekOgrenci;
        Kitap kitap;
        KutuphaneIslemleri ilgiliIslem;

        //İşlem görecek öğrenciye tc si ile ulaşıyorum.
        public KitapIadeEt(string ogrenciTC)
        {
            IslemGorecekOgrenci = Tablolar.Ogrenciler.GetByIdWithIslemler(ogrenciTC);
       
            InitializeComponent();
        }
        //iade edilebilecek kitapları öğrenci tcsi ile ulaşıp getiriyorum sonra datagride işliyorum.
        private void KitapIadeEt_Load(object sender, EventArgs e)
        {
            cmb_IadeEdilecekKitap.DataSource = Tablolar.Ogrenciler.GetZimmetliKitaplarID(IslemGorecekOgrenci.OgrenciTc).ToList();
            var kitap = Tablolar.Ogrenciler.GetZimmetliKitaplarID(IslemGorecekOgrenci.OgrenciTc).GetKitaplar();
            dataGridIadeEdilebilecekKitaplar.DataSource = kitap;
            dataGridIadeEdilebilecekKitaplar.KitapBaslik();
            dataGridIadeEdilebilecekKitaplar.Columns["KitapIslemler"].Visible = false;
        }
        //Kullanıcı isterse iade etmek istediği kitabı textboxa yazıp bulabilir gerekli sorguları yapıyorum kitap ismi kitaplarda varsa olan kitabın iade tarihi yok ve işlem gördüğü öğrencinin tcsi bizim öğrencimizin tc siyle aynı ise kitabı getir diyorum. Teslim tarihine 15 gün ekleyip ücret kısmına yazdıgım metotu cagırıp gerekli hesaplamaları yaptırıp yazdırıyorum.
        private void txt_AranacakKitap_TextChanged(object sender, EventArgs e)
       {
            kitap = Tablolar.Kitaplar.GetKitapWithIslemler().ZimmetliKitaplardaAra(txt_AranacakKitap.Text);
            
            if (kitap == null)
            {
                MessageBox.Show("Aranan Kitap Bulunamadı.");
            }
            else if (!String.IsNullOrEmpty(txt_AranacakKitap.Text))
            {
                cmb_IadeEdilecekKitap.SelectedIndex = cmb_IadeEdilecekKitap.Items.IndexOf(kitap.BarkodNo);
                ilgiliIslem = kitap.KitapIslemler.First(x => x.KitapIadeTarihi == null && x.OgrenciTC == IslemGorecekOgrenci.OgrenciTc);
                dtp_alinisTarihi.Value = ilgiliIslem.KitapAlimTarihi;
                dtp_teslimTarihi.Value = ilgiliIslem.KitapAlimTarihi.AddDays(15);
                lbl_ucret.Text = ilgiliIslem.GetBorc().ToString();
            }
            else
            {
                cmb_IadeEdilecekKitap.SelectedItem = null;
                dtp_alinisTarihi.Value = DateTime.Now;
                dtp_teslimTarihi.Value = DateTime.Now;
                lbl_ucret.Text = "...";
            }
        }
        // butona basıldığında ise kitabın alınabilir mi özelliğini true yapıp iade tarihine o anı atıyorum. Update işlemlerini yapıp mesaagebox ile öğrenci borcunu yazdırıyorum.
        private void button1_Click(object sender, EventArgs e)
        {
            if (kitap!=null)
            {
                kitap.alinabilirMi = true;
                ilgiliIslem.KitapIadeTarihi = DateTime.Now;
                Tablolar.Kitaplar.Update(kitap);
                Tablolar.Islemler.Update(ilgiliIslem);
                MessageBox.Show($"İade işlemi başarılı öğrenci borcu : {lbl_ucret.Text} TL");
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen kitabı seçiniz veya aratınız.");
            }
        }
        // datagrid üzerinden iade edilecek kitap seçilirse diye gerekli kodlar.
        private void dataGridIadeEdilebilecekKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_AranacakKitap.Text = dataGridIadeEdilebilecekKitaplar.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}

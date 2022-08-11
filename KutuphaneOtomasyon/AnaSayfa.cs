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
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Entitys.Models;
using DTO.Concrete;
using DTO.Abstract;
using Businesss;
using static Veritabani.TablolarRepo;
namespace KutuphaneOtomasyon
{
	public partial class AnaSayfa : Form
	{

		public AnaSayfa()
		{
			InitializeComponent();
		}
		//Burada gridleri yeniliyoruz özetle her seferinde sütunları temizleyip baştan çağırıyoruz. Düğme tasarımını kullandığım için düğme oluşturup isimlendirip atamasını yaptım OgrenciIslemler ve KitapIslemler görünmez yaptım cunku onlar profil ve diğer işlemler için lazım kullanıcının bu alanda görmesine gerek yok extend classında tanımlı yenile metotuyla yenileme işlemini yapıp daha güzel bir görüntü için başlıklarını değiştirme fonksiyonunu cagırdım.
		void GridsYenile()
		{
			dataGridOgrenci.Columns.Clear();
			dataGridKitap.Columns.Clear();
			DataGridViewButtonColumn btn = new DataGridViewButtonColumn
			{
				UseColumnTextForButtonValue = true,
				Text = "Kitap Emanet Al",
			};
			DataGridViewButtonColumn btn1 = new DataGridViewButtonColumn
			{
				UseColumnTextForButtonValue = true,
				Text = "Kitap İade Et",
			};
			DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn
			{
				UseColumnTextForButtonValue = true,
				Text = "Profile Git",
			};
			DataGridViewButtonColumn btn3 = new DataGridViewButtonColumn
			{
				UseColumnTextForButtonValue = true,
				Text = "Profile Git",
				HeaderText="Profil"
			};
			dataGridOgrenci.Yenile<Ogrenci>();
			dataGridKitap.Yenile<Kitap>();
			dataGridOgrenci.Columns["OgrenciIslemler"].Visible = false;
			dataGridKitap.Columns["KitapIslemler"].Visible = false;
			dataGridOgrenci.Columns.Add(btn);
			dataGridOgrenci.Columns.Add(btn1);
			dataGridOgrenci.Columns.Add(btn2);
			dataGridKitap.Columns.Add(btn3);
			dataGridOgrenci.OgrenciBaslik();
			dataGridKitap.KitapBaslik();
			dataGridKitap.ClearSelection();
			dataGridOgrenci.ClearSelection();
		}
		
		private void AnaSayfa_Load(object sender, EventArgs e)
        {
			GridsYenile();
        }

		//bu butona basıldığında Öğrenci ekle için form nesnesini oluşturup o nesneye gitmesini söylüyoruz yukarıda oluşturdugumuz metotu cagırıyoruz.
		private void OgrenciEkle_btn_Click(object sender, EventArgs e)
		{
			OgrenciEkleme ogrenciEkleme = new OgrenciEkleme();
			ogrenciEkleme.ShowDialog();
			GridsYenile();
		}

		//Öğrenci güncelleme için istenilen öğrencinin bilgileri lazım ogrenci ekleme formunda bu bilgileri kullanıp textboxlara yazdırıyorum daha iyi bir görünüm ve sadece istenilen bilginin değiştirilmesi için. Seçili mi diye kontrol ettirip istediğim bilgileri secilisatir adlı değişkene seçilen satırı atıyıp o satırın hücrelerindeki bilgilere göre atama işlemlerini yapıyorum.
		private void OgrenciGuncelleme_btn_Click(object sender, EventArgs e)
		{
			if (dataGridOgrenci.SelectedRows.Count > 0)
			{
				OgrenciEkleme OgrEkle = new OgrenciEkleme(true);
				DataGridViewRow seciliSatir = dataGridOgrenci.SelectedRows[0];
				OgrEkle.txt_OgrenciTc.Text = (string)seciliSatir.Cells[0].Value;
				OgrEkle.OgrenciAdi_txt.Text = (string)seciliSatir.Cells[1].Value;
				OgrEkle.OgrenciSoyadi_txt.Text = (string)seciliSatir.Cells[2].Value;
				OgrEkle.OgrenciOkul_txt.Text = (string)seciliSatir.Cells[3].Value;
				OgrEkle.ShowDialog();
				GridsYenile();
			} else MessageBox.Show("Seçiniz!");

		}

		//Kitap Ekle formunun nesnesini oluşturup erişiyorum.
		private void KitapEkle_btn_Click(object sender, EventArgs e)
		{
			KitapEkle kitapEkle = new KitapEkle();
			kitapEkle.ShowDialog();
			GridsYenile();
		}


		//Öğrenci Güncelleme metotunda yaptığımız aynı işlemleri kitap güncelleme içinde yapıyoruz.
		private void KitapGuncelle_btn_Click(object sender, EventArgs e)
		{
			if (dataGridKitap.SelectedRows.Count > 0)
			{
				KitapEkle kitapEkle = new KitapEkle(true);
				DataGridViewRow seciliSatir = dataGridKitap.SelectedRows[0];
				kitapEkle.txt_BarkodNo.Text = (string)seciliSatir.Cells[0].Value;
				kitapEkle.txt_KitapIsmi.Text = (string)seciliSatir.Cells[1].Value;
				kitapEkle.txt_KitapYazari.Text = (string)seciliSatir.Cells[2].Value;
				kitapEkle.cmb_KitapTuru.Text = (string)seciliSatir.Cells[3].Value.ToString();
				kitapEkle.txt_KitapSayfa.Text = (string)seciliSatir.Cells[4].Value.ToString();
				kitapEkle.ShowDialog();
				GridsYenile();
			} else MessageBox.Show("Seçiniz!");
		}

		//Silinecek öğrenci için o satır seçili mi diye bakıyoruz satır seçiliyse o satırın ilk hücresindeki öğrenci Id adlı biligiyi alıp atıyoruz sonra bir ogrenci oluşturup o bilgiye göre öğrenci bilgilerini getirecek metotu tablolar ogrenciler getbyidwithıslemler metotuna parametre olarak verip istenilen öğrencinin nesnesini buluyoruz. Sonrasında bu öğrencinin üstüne bir kitap zimmetli mi diye kontrol ettiriyoruz kitap zimmetliyse o kitabın alınabilir mi propunu true yaparak boşa çıkartıyoruz. Yani öğrenciyi işlemleriyle beraber siliyoruz.
		private void OgrenciSilme_btn_Click(object sender, EventArgs e)
		{
			if (dataGridOgrenci.SelectedRows.Count > 0)
			{
				string silinecekOgrenci = dataGridOgrenci.SelectedRows[0].Cells[0].Value.ToString();
				Ogrenci ogrenci = Tablolar.Ogrenciler.GetByIdWithIslemler(silinecekOgrenci);
				if (ogrenci == null)
				{
					MessageBox.Show("Öğrenci seçiniz.");
				} else
				{
					DialogResult Secim = new DialogResult();
					Secim = MessageBox.Show($"{ogrenci.OgrenciTc} TC ' li  {ogrenci.OgrenciAdi} {ogrenci.OgrenciSoyadi} Adlı Öğrenciyi Silmek İstediğinize Emin misiniz ?", "Öğrenci Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
					if (Secim == DialogResult.Yes)
					{
						if (ogrenci.OgrenciIslemler != null)
						{
							foreach (var item in ogrenci.OgrenciIslemler)
							{
								var kitap = Tablolar.Kitaplar.GetById(item.KitapID);
								kitap.alinabilirMi = true;
								Tablolar.Kitaplar.Update(kitap);
							}
							Tablolar.Islemler.RemoveRange(ogrenci.OgrenciIslemler);
						}
						Tablolar.Ogrenciler.Remove(silinecekOgrenci);
						MessageBox.Show("Öğrenci Silme İşlemi Başarılı.");
						GridsYenile();
					}
				}
			} else MessageBox.Show("Seçiniz!");
		}


		// Öğrenci silmedeki aynı işlemleri yapıyoruz ama kitap birinin üstüne zimmetliyse kitabın kimin üstüne zimmetli olduğunu ve silinemeyeceğini kullanıcıya bildiriyoruz.
		private void KitapSil_btn_Click(object sender, EventArgs e)
		{
			if (dataGridKitap.SelectedRows.Count > 0)
			{
				string silinecekKitapID = dataGridKitap.SelectedRows[0].Cells[0].Value.ToString();
				Kitap kitap = Tablolar.Kitaplar.GetKitapByIdWithIslemler(silinecekKitapID);
				if (kitap == null)
					MessageBox.Show("Kitap Seçiniz.");
				else
				{
					if (!kitap.alinabilirMi)
					{
						var ogrTC = kitap.KitapIslemler.First(x => x.KitapIadeTarihi == null).OgrenciTC;
						Ogrenci islemYapanOgrenci = Tablolar.Ogrenciler.GetById(ogrTC);
						MessageBox.Show($"Bu kitap {islemYapanOgrenci.OgrenciTc} - {islemYapanOgrenci.OgrenciAdi} adlı öğrenciye zimmetlidir silinemez.");
					} else
					{
						DialogResult Secim = new DialogResult();
						Secim = MessageBox.Show($"{kitap.KitapAdi} Adlı Kitabı Silmek İstediğinize Emin Misiniz ?", "Kitap Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
						if (Secim == DialogResult.Yes)
						{
							Tablolar.Islemler.RemoveRange(kitap.KitapIslemler);
							Tablolar.Kitaplar.Remove(kitap.BarkodNo);
							GridsYenile();
							MessageBox.Show("Kitap Silme İşlemi Başarılı");
						}
					}

				}
			} else MessageBox.Show("Seçiniz!");
		}


		//Burada da kitap datagridinin düğmeleri için gerekli kodlar var. Düğmeye basıldığında o satırı seçili yaptım ve seçilen satırdan da barkod numarasını alıp kitap detay sınıfına parametre olarak gönderdim.
		private void dataGridKitap_CellClick(object sender, DataGridViewCellEventArgs e)
		{
            if (e.RowIndex != -1)
            {
				var secilenKitapBarkodNo = dataGridKitap.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (e.ColumnIndex == dataGridKitap.Columns.Count - 1)
				{
					Profil kitapDetay = new Profil(secilenKitapBarkodNo, "kitap");
					kitapDetay.ShowDialog();
				}
			}
		}


		//Burada da aynı şekilde öğrenci tcye ulaşıp istenilen işlemler için öğrenci tcyi parametre olarak sınıflara veriyoruz.
        private void dataGridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			if (e.RowIndex != -1)
			{
				var secilenOgrTC = dataGridOgrenci.Rows[e.RowIndex].Cells[0].Value.ToString();
				if (e.ColumnIndex == (dataGridOgrenci.Columns.Count - 1))
				{
					Profil ogrenciDetay = new Profil(secilenOgrTC,"ogrenci");
					ogrenciDetay.ShowDialog();
				}
				else if (e.ColumnIndex == dataGridOgrenci.Columns.Count - 2)
				{
					KitapIadeEt iadeEt = new KitapIadeEt(secilenOgrTC);
					iadeEt.ShowDialog();
					GridsYenile();
				}
				else if (e.ColumnIndex == dataGridOgrenci.Columns.Count - 3)
				{
					KitapEmanetAl emanetAl = new KitapEmanetAl(secilenOgrTC);
					emanetAl.ShowDialog();
					GridsYenile();
				}
				
			}
		}
		//Grafik için.
        private void btn_grafik_Click(object sender, EventArgs e)
        {
			Grafik grafik = new Grafik();
			grafik.ShowDialog();
		}
    }
}

using DTO.Concrete;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Veritabani.TablolarRepo;
namespace Businesss
{
    public static class Extend
    {
        //Bu metot ogrenci Borcunu getirmesi içindir this diyerek KutuphaneIslemlerinin uzantısı olarak erişebiliyoruz bu tipte bir değer vermemiz gerekiyor. gecengunsayisi adli bir değişken oluşturup teslimekalangun metotunu cagırıyoruz sonucu bu değişkene atıyıp gecengunsayisi eksi ise else diyerek borcu donduruyoruz. 0 veya + ise 0 sonucu dönüyor.
        public static double GetBorc(this KutuphaneIslemleri item)
        {
            var gecenGunSayisi = TeslimeKalanGun(item);
            if (gecenGunSayisi >= 0)
                return 0;
            else return Math.Round(gecenGunSayisi * -1, 2);
        }
        //Yine aynı şekilde uzantı olarak yazılmıştır. sonTeslim adlı değişkeni kullanıp alimtarihine 15 gün ekleyerek atamasını yapıyoruz. iade tarihi varsa result adlı değişkene teslim tarihinden iade tarihini çıkartıp atıyoruz iade tarihi varsa teslim tarihinden bugunu cıkartıp atıyoruz sonucu donduruyoruz.
        public static double TeslimeKalanGun(this KutuphaneIslemleri item)
        {
            var result = 0.0;
            var sonTeslim = item.KitapAlimTarihi.AddDays(15);
            if (item.KitapIadeTarihi != null)
                result = (sonTeslim - item.KitapIadeTarihi
                    .Value).TotalDays;
            else
                result = (sonTeslim - DateTime.Now).TotalDays;
            return Math.Round(result, 2);
        }
        //Zimmetli kitaplarda arama yapıyoruz. Kitap İade et kısmı içindir. Kitap tipinde kitaplar adlı bir liste oluşturulup uzantısı yapılmıştır ve aranacak text ile firstordefault fonksiyonu kullanılıp kitap adı uyan ve kitap iade tarihi olmayan yani zimmetli olan kitabı bul ve döndür olarak özetleyebilirim.
        public static Kitap ZimmetliKitaplardaAra(this List<Kitap> kitaplar, string aranacakText)
        {
            return kitaplar.FirstOrDefault(x => x.KitapAdi.ToLower().Contains(aranacakText?.ToLower()) && x.KitapIslemler.Any(y => y.KitapIadeTarihi == null)
                );
        }

        //Her değişiklikte datagrid i yenilemem gerekiyordu. Kod tekrarının önüne geçmek için bu fonksiyonu yazdım her güncelleme sonunda da çağırdım.
        public static void Yenile<T>(this DataGridView grid) where T : class
        {
            DatabaseContext dbContext = new DatabaseContext();
            BaseRepository<T> repo = new BaseRepository<T>(dbContext);
            grid.DataSource = repo.GetList();
        }

        public static void KitapBaslik(this DataGridView grid) 
        {
            grid.Columns[0].HeaderText = "BARKOD NO";
            grid.Columns[1].HeaderText = "KİTAP ADI";
            grid.Columns[2].HeaderText = "KİTAP YAZARI";
            grid.Columns[3].HeaderText = "BASKI TARİHİ";
            grid.Columns[4].HeaderText = "SAYFA SAYISI";
            grid.Columns[5].HeaderText = "TÜRÜ";
            grid.Columns[6].HeaderText = "MÜSAİT";           
        }
        public static void OgrenciBaslik(this DataGridView grid) 
        {
            grid.Columns[0].HeaderText = "ÖĞRENCİ TC";
            grid.Columns[1].HeaderText = "ÖĞRENCİ İSİM";
            grid.Columns[2].HeaderText = "ÖĞRENCİ SOYİSİM";
            grid.Columns[3].HeaderText = "ÖĞRENCİ OKUL";
            grid.Columns[5].HeaderText = "EMANET";
            grid.Columns[6].HeaderText = "İADE";
            grid.Columns[7].HeaderText = "PROFİL";
        }
        public static void DetayBaslik(this DataGridView grid)
        {
            string x = grid.Columns[1].Name.Contains("Ogrenci") ? "Öğrenci" : "Kitap";
            grid.Columns[0].HeaderText = "İşlem ID";
            grid.Columns[1].HeaderText = x+" Adı";
            grid.Columns[2].HeaderText = "Kitap Alım Tarihi";
            grid.Columns[3].HeaderText = "Son Teslim Tarihi";
            grid.Columns[4].HeaderText = "İade Tarihi";
            grid.Columns[5].HeaderText = "İşlem Cezası";
        }
       

        //Tüm kitaplara ulaşmak içindir. Uzantı olarak tanımlanan liste tipinde barkodNo paremetre olarak alıyorum ve kitaplar adında yeni bir liste oluşturuyorum. Foreachle tüm barkodNoları döndürüp kitaplar listesine tablolardan kitaplara kitaplardan da idye göre kitabı ata diyerek ekleme yapıyorum en son olarak oluşan listeyi döndürüyorum sonuç olarak tüm kitaplar barkod numarasına göre bulunup listeleniyor.
        public static List<Kitap> GetKitaplar(this List<string> barkodNo) {
            List<Kitap> kitaplar = new List<Kitap>();
            foreach (var item in barkodNo)
            {
                kitaplar.Add(Tablolar.Kitaplar.GetById(item));
            }
            return kitaplar;
        }
        public static void Delete<T>(this DataGridView data, T SilinecekObje)
        {
            string silinecekVeri = data.SelectedRows[0].Cells[0].ToString();
        }
        //Boya işlemleri içindir. grid nesnesi uzantılıdır. Verilen datagridin satırlarını foreach ile dönüyoruz ve islem görecek kitabı getById metotu ile atıyoruz gerekli bilgiyide satırın ilk hücresi olan id bilgisini atayarak elde ediyoruz. Sonrasında null değilse kontrol ettirip kalangunu teslimekalangun metotu sayesinde atama yapıp iadetarihi varsa kitabı yeşile geçmişse kırmızıya 2 gün kalmışsa da sarıya boyayarak istenilen sonuca ulaşıyoruz.
        public static void Boya(this DataGridView grid)
        {
            foreach (DataGridViewRow item in grid.Rows)
            {
                var islem = Tablolar.Islemler.GetById((int)item.Cells[0].Value);
                if (islem != null)
                {
                    var kalanGun = islem.TeslimeKalanGun();
                    if (islem.KitapIadeTarihi != null)
                    {
                        item.DefaultCellStyle.BackColor = Color.Green;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (kalanGun < 0)
                    {
                        item.DefaultCellStyle.BackColor = Color.Red;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (kalanGun <= 2)
                    {
                        item.DefaultCellStyle.BackColor = Color.Yellow;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }

                }
            }
        }
    }
}

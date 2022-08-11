using DTO.Concrete;
using KutuphaneOtomasyon.DatabaseContext2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Veritabani
{
    public class TablolarRepo
    {
        //newlenmesini istemediğimiz için private yapıyoruz.
        private TablolarRepo()
        {
            context = new DatabaseContext();
            Ogrenciler = new OgrenciRepository(context);
            Kitaplar = new KitapRepository(context);
            Islemler = new IslemlerRepository(context);
        }
        // Yukarıdaki yapıcı metot private bu metota her seferinde değişiklikleriyle beraber getirmek için böyle bir prop oluşturduk ve her seferinde yukarıdaki metotu ayağa kaldırıyor verileri güncelleyip getiriyoruz. Tüm işlemleri bu prop üzerinden yapıyoruz.
        public static TablolarRepo Tablolar
        {
            get
            {
                return new TablolarRepo();
            }
        }
        //Burada ihtiyacımız olan propları tanımlıyoruz.
        private DatabaseContext context { get; set; }
        public OgrenciRepository Ogrenciler { get; set; }
        public KitapRepository Kitaplar { get; set; }
        public IslemlerRepository Islemler { get; set; }

    }
}

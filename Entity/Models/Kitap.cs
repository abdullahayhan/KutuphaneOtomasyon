using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Models
{
     public class Kitap
    {
        //Kitap nesnesi için propertyler barkodNo tablonun anahtarıdır boş geçilemez olarak damgaladım. Kitap Türü enum tipindedir. alinabilirMi propu default olarak true olarak verildi ve bu tablo KutuphaneIslemleri ile ilişkilidir.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public string BarkodNo { get; set; }
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public DateTime KitapBaskiTarihi { get; set; }
        public int KitapSayfaSayisi { get; set; }
        public KitapTuru KitapTuru { get; set; }
        public bool alinabilirMi { get; set; } = true;
        public ICollection<KutuphaneIslemleri> KitapIslemler { get; set; }

    }
}

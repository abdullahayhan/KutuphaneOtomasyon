using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Models
{
    //kütüphane işlemleri içindir. birincil anahtarı IslemID ve kitap ve ogrenci tablolarıyla ilişkilidir bu ilişkiden dolayı foreignKey olarak damgalanmıştır.
    public class KutuphaneIslemleri
    {
        [Key]
        public int IslemID { get; set; }
        public Kitap Kitap { get; set; }
        [ForeignKey("Kitap")]
        public string KitapID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        [ForeignKey("Ogrenci")]
        public string OgrenciTC { get; set; }
        public DateTime KitapAlimTarihi { get; set; }
        public DateTime? KitapIadeTarihi { get; set; } = null;
        public double Ucret { get; set; }
    }
}

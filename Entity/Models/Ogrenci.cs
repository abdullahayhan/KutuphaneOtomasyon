using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitys.Models
{
    //Öğrenci nesnesi ve propertiylerini oluşturdum. ogrenciTc tablonun anahtar propertysidir ve bu tablo KutuphaneIslemleri ile ilişkilidir.
    public class Ogrenci
    {
        [Key]
        public string OgrenciTc { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public string OgrenciOkul { get; set; }
        public ICollection<KutuphaneIslemleri> OgrenciIslemler { get; set; }
    }
}

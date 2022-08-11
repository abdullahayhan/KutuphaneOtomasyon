using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    //ogrenci profili için oluşturulmuştur.
    public class OgrenciIslemBilgi
    {
        public int IslemID { get; set; }    
        public string KitapAdi { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public DateTime SonTeslimTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public double IslemCezasi { get; set; }
    }
}

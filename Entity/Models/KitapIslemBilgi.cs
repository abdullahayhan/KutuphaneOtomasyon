using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public class KitapIslemBilgi
    {
        //KitapIslemBilgi kitabın bilgileri ve profili için oluşturulmuştur.
        public int IslemID { get; set; }
        public string OgrenciAdi { get; set; }
        public DateTime AlinmaTarihi { get; set; }
        public DateTime SonTeslimTarihi { get; set; }
        public DateTime? IadeTarihi { get; set; }
        public double IslemCezasi { get; set; }
    }
}

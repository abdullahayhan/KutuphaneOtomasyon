using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    //Aynı şekilde KutuphaneIslemlerini verip miras alarak tüm metotlarına ulaşıyorum.
    internal interface IKutuphaneIslemRepository : IBaseRepository<Entitys.Models.KutuphaneIslemleri>
    {
        
    }
}

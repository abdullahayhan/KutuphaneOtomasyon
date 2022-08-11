using Entitys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    //Sadece IBaseRepository işlemlerini istiyorum kitap sınıfını veri miras alarak ulaşıyorum.
    internal interface IKitapRepository : IBaseRepository<Kitap>
    {
    }
}

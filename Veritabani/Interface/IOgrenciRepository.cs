using Entitys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    internal interface IOgrenciRepository : IBaseRepository<Ogrenci>
    {
        //BaseRepository e ek olarak öğrenciyi işlemleriyle döndürmesini isteyen metot imzasını atıyorum.
        List<Ogrenci> GetOgrenciWithIslemler();
    }
}

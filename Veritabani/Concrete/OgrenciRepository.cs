using DTO.Abstract;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    //interface olarak IOgrenciRepository alıyor ve BaseRepositoryi generic olarak tanımladığım için Ogrenci classını verip mirasını alıyorum böylelikle metotlarına erişiyorum.
    public class OgrenciRepository : BaseRepository<Ogrenci>, IOgrenciRepository
    {
        public OgrenciRepository(DatabaseContext context) : base(context)
        {

        }
        //tcsine göre öğrenciyi işlemleriyle bulup döndürüyor.
        public Ogrenci GetByIdWithIslemler(string ogrenciTc) 
        {
            return GetOgrenciWithIslemler().FirstOrDefault(x=>x.OgrenciTc==ogrenciTc);
        }
        //öğrenciye işlemlerini dahil edip liste tipinde döndürüyor.
        public List<Ogrenci> GetOgrenciWithIslemler()
        {
            return _dbSet.Include(x=>x.OgrenciIslemler).ToList();
        }
        //Öğrencinin idsini parametre olarak alıp öğrencinin işlemlerini dahil ediyorum sonra bu öğrenci üstünden işlemlerinde kitap iade tarihi olmayan kitabı bulup kitabın idsini liste tipinde döndürüyorum. Böylelikle öğrencinin tc ile üzerindeki kitaplara ulaşabiliyoruz.
        public List<string> GetZimmetliKitaplarID(string ogrID)
        {
            var x = GetByIdWithIslemler(ogrID).OgrenciIslemler;
            return x.Where(x => x.KitapIadeTarihi == null).Select(x=> x.KitapID).ToList();
        }
        //Tüm işlemlerinin kitab idlerini döndürüyorum öğrenci profili için.
        public List<string> GetTumIslemler(string ogrID)
{
            return GetByIdWithIslemler(ogrID).OgrenciIslemler.Select(x => x.KitapID).ToList();
        }
        //Öğrenciye işlemleriyle birlikte ulaşıp kitap iade tarihi olan kitapların idlerini döndürüyorum iade edilen kitaplarına ulaşmak için.
        public List<string> GetIadeEdilenKitaplar(string ogrID)
        {
            return GetByIdWithIslemler(ogrID).OgrenciIslemler.Where(x => x.KitapIadeTarihi != null).Select(x => x.KitapID).ToList();
        }
    }
}

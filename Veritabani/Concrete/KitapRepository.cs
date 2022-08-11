using DTO.Abstract;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    //interface olarak IKitapRepository alıyor ve BaseRepositoryi generic olarak tanımladığım için kitap classını verip mirasını alıyorum böylelikle metotlarına erişiyorum.
    public class KitapRepository : BaseRepository<Kitap>, IKitapRepository
    {
        public KitapRepository(DatabaseContext context) : base(context)
        {

        }
        //İstenilen kitaba işlemlerini dahil edip liste tipinde döndürüyor.
        public List<Kitap> GetKitapWithIslemler()
        {
            return _dbSet.Include(x => x.KitapIslemler).ToList();
        }
        //İstenilen kitabın idsi ile o kitaba erişiyor ve yukarıdaki metotu kullanarak İşlemlerini dahil edip döndürüyoruz.
        public Kitap GetKitapByIdWithIslemler(string barkodNo) 
        {
            return GetKitapWithIslemler().Find(x=>x.BarkodNo==barkodNo);
        }
        //Kitabı ismine göre döndürüyoruz. Arama kısımları için yazdım
        public Kitap GetByName(string name)
        {
            return  GetKitapWithIslemler().FirstOrDefault(x => x.KitapAdi.ToLower().Equals(name.ToLower()));
        }
        public List<Kitap> GetAllZimmetliKitaplar()
        {
            return _dbSet.Where(x => x.alinabilirMi == false).ToList();
        }
        public List<Kitap> GetAvailableKitap()
        {
            return _dbSet.Where(x => x.alinabilirMi == true).ToList();
        }
        public List<string> GetAvailableKitapBarkodNo()
        {
            return GetAvailableKitap().Select(x => x.BarkodNo).ToList();
        }
    }
}

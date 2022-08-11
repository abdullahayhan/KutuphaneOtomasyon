using DTO.Abstract;
using KutuphaneOtomasyon.DatabaseContext2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    //generic tipte oluşturdum ve T nin class oldugunu belirttim interfacesini dahil ettim
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DatabaseContext _context;
        protected DbSet<T> _dbSet;
        //global alanda tanımladıgım değişkenleri constructordan aldıgım degerlerle atamasını yapıyorum
        public BaseRepository(DatabaseContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        // Ekleme işlemini veritabanına yapıyorum.
        public void Add(T entity) {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        //
        public void AddRange(IEnumerable<T> list) {
            _dbSet.AddRange(list);
            _context.SaveChanges();

        }

        // ID sine göre istenilen nesneyi getiriyor.
        public T GetById(int ID) {
            return _dbSet.Find(ID);
        }
        // ID si string ise bunu kullanıyorum.
        public T GetById(string ID)
        {
            return _dbSet.Find(ID);
        }
        // Hangi nesnenin listesi isteniyorsa o nesneye ait tüm verileri veritabanında bulup liste tipinde döndürüyor.
        public IEnumerable<T> GetList() {
            return _dbSet.ToList();
        }
        // İstenilen nesneyi getById metotunu kullanarak getiriyor ve veritabanında siliyor değişiklikleri kaydediyoruz.
        public void Remove(int ID) {
            _dbSet.Remove(GetById(ID));
            _context.SaveChanges();
        }
        //aynı işlemi id string ise yapıyorum 
        public void Remove(string ID)
        {
            _dbSet.Remove(GetById(ID));
            _context.SaveChanges();
        }
        public void RemoveRange(IEnumerable<T> list) {
            _dbSet.RemoveRange(list);
            _context.SaveChanges();
        }
        // Veri Güncellemesi için oluşturdugum metot
        public void Update(T obje)
        {
            _dbSet.Update(obje);
            _context.SaveChanges();
        }
    }
}

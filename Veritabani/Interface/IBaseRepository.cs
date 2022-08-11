using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Abstract
{
    // BaseRepository classı için oluşturdugum interfacenin içinde override yapılacak metotları tanımladım generic olarak yaptım ve T nin bir class oldugunu damgaladım.
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetList();
        T GetById(int ID);
        void Add(T entity);
        void AddRange(IEnumerable<T> list);
        void Remove(int ID);
        void RemoveRange(IEnumerable<T> list);
        void Update(T obje);

    }

}

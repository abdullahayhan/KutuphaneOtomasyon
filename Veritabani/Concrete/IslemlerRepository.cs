using DTO.Abstract;
using Entitys.Models;
using KutuphaneOtomasyon.DatabaseContext2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Concrete
{
    public class IslemlerRepository : BaseRepository<KutuphaneIslemleri>, IKutuphaneIslemRepository
    {
        public IslemlerRepository(DatabaseContext context) : base(context)
        {
        }
    }
}

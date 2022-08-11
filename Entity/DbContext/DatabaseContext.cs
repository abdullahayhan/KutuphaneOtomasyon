using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Entitys.Models;

namespace KutuphaneOtomasyon.DatabaseContext2
{
    public class DatabaseContext : DbContext
    {
        //veritabanına bağlayıp sql lite için localdb yaptım 
        string DBConnection = "Data Source=KutuphaneDB.db";
        //string DBConnection = @"Data Source=C:\Users\NB\Desktop\Kutuphane Otomasyon\KutuphaneOtomasyon\KutuphaneOtomasyon\bin\Debug\net5.0-windows\KutuphaneDB.db";

        //konfigürasyon işlemlerini yapıp veritabanı yolunu belirledim.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(DBConnection); // veritabanının yolunu belirliyoruz.
        }

        //Burada da Kitaplar Ogrenciler ve Islemler adında üç adet tablo oluşturdum içerikleri models klasöründedir.
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<KutuphaneIslemleri> Islemler { get; set; }

    }

}

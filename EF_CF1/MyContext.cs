using EF_CF1.Entities;
using System.Data.Entity;

namespace EF_CF1
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=Mycon")
        {

        }
        public virtual DbSet<Kategori> Kategoriler { get; set; } //connection stringi ekle
        public virtual DbSet<Urun> Urunler { get; set; }

    }
}

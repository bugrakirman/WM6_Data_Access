using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF1.Entities
{
    [Table("Kategoriler")]
    public class Kategori
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20,ErrorMessage ="kategori adi 20den fazla olamaz olamaz olamaz",MinimumLength =2)]
        [Index("IX_KategoriUnique",IsUnique =true)]
        public string KategoriAdi { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        public DateTime eklenmeZamani { get; set; } = DateTime.Now;

        public virtual ICollection<Urun> Urunler { get; set; } = new HashSet<Urun>();
    }
}

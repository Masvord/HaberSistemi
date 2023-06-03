using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Kullanici")]
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(50, ErrorMessage = "50'den fazla karakter girmeyiniz.")]
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }
       
        [Display(Name = "E Mail")]
        [Required] /* Boşluk içermemeli anlamına geliyor.*/
         public string Email { get; set; }
        
        [Display(Name = "Sifre")]
        [DataType(DataType.Password)]
        [Required]
        [MaxLength(16, ErrorMessage = "16'dan fazla karakter girmeyiniz.")]
        public string Sifre { get; set; }
        

        public DateTime KayitTarihi { get; set; }
        [Display(Name ="Aktif")]

        public bool Aktif { get; set; }

        public virtual Rol Rol { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Haber")]
    public class Haber
    {
        [Key]

        public int ID { get; set; }


        [Display(Name ="Haber Başlık")]
        [MaxLength(255,ErrorMessage ="Çok fazla değer girdiniz.")]
        [Required]
        public string Baslik { get; set; }


        [Display(Name = "Kısa Açıklama")]
        public string KisaAciklama { get; set; }


        public int Okuma { get; set; }



        [Display(Name = "Açıklama")]
        public string Aciklama { get; set; }


        [Display(Name = "Aktif")]
        public bool AktifMi { get; set; }


        [Display(Name = "Ekleme Tarihi")]
        public DateTime EklemeTarihi { get; set; }

        public virtual Kullanici Kullanici { get; set; }


        [Display(Name = "Resim")]
        [MaxLength(255, ErrorMessage = "Çok fazla değer girdiniz.")]
        public string Resim { get; set; }
        public virtual ICollection<Resim> Resims { get; set; }
        //Resimle bağlantı kurmaya yarar. Tekrar resim yazarsak hata alırız bu yüzden resims yazdık.


        public virtual Kategori Kategori { get; set; }

    }
}

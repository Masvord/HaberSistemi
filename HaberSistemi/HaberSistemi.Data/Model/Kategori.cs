using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int ID { get; set; }

        [MinLength(2, ErrorMessage = "{0} karakterden az olamaz."), MaxLength(150, ErrorMessage = "{0} karakterden fazla olamaz.")]
        public string KategoriAdi { get; set; }


        public int ParentID { get; set; }



        [MinLength(2, ErrorMessage = "{0} karakterden az olamaz."), MaxLength(150, ErrorMessage = "{0} karakterden fazla olamaz.")]
        public string URL { get; set; }

        public bool AktifMi { get; set; }

        public virtual ICollection<Haber> Haber { get; set; }
    }
}

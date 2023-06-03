using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Data.Model
{
    [Table("Rol")]
    public class Rol
    {
        [Key]
        public int ID { get; set; }
        [Display(Name="Rol Adi:")]
        [MinLength(3,ErrorMessage ="Lutfen 3 karakterden fazla deger girin."), MaxLength(100, ErrorMessage ="100 karakterden fazla deger girmeyiniz.")]
        public string RolAdi { get; set; }
    }
}

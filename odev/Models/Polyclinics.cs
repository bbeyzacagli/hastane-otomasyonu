using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("Polyclinics")]
    public class Polyclinics
    {
        [Key]
        public int PolyclinicId { get; set; }


        [Required(ErrorMessage ="Poliklinigin ismi bos kalamaz")]
        [Display(Name ="Polyclinic")]
        public string? PolyclinicName { get; set; }


        [Required(ErrorMessage = "Poliklinigin doktor sayisi girilmelidir")]
        [Range(1,8,ErrorMessage="Poliklinigin doktor sayisi en az 1, en fazla 8 olabilir.")]
        public int Doctors { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("WorkingHours")]
    public class WorkingHours
    {
        [Key]
        public int HourId { get; set; }


        [Required(ErrorMessage = "Doktorun ismi bos olamaz")]
        [Display(Name = "DoctorName")]
        public string? DoctorName { get; set; }


        [Required(ErrorMessage = "Doktorun soyadi bos olamaz")]
        [Display(Name = "DoctorSurname")]
        public string? DoctorSurname { get; set; }


        [Required(ErrorMessage = "Doktorun calisma gunu bos olamaz")]
        [Display(Name = "Days")]
        public String? Days {  get; set; }

        public int Start {  get; set; }

        public int End { get; set; }
    }
}

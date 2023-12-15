using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("Doctors")]
    public class Doctors
    {
        [Key]
        public int DoctorId { get; set; }


        [Required(ErrorMessage ="Doktorun ismi bos olamaz")]
        [Display(Name ="DoctorName")]
        public string? DoctorName { get; set; }


        [Required(ErrorMessage = "Doktorun soyadi bos olamaz")]
        [Display(Name = "DoctorSurname")]
        public string? DoctorSurname { get; set; }


        [Required(ErrorMessage = "Doktorun mail adresi bos olamaz")]
        [Display(Name = "DoctorEmail")]
        [DataType(DataType.EmailAddress)]
        public string? DoctorEmail { get; set; }


        [Required(ErrorMessage = "Doktorun bolumu bos olamaz")]
        [Display(Name = "DoctorDepartment")]
        public string? DoctorDepartment { get; set; }

    }
}

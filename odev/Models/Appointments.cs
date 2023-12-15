using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("Appointments")]
    public class Appointments
    {
        [Key]
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        [Required(ErrorMessage = "Hastanin ismi bos olamaz")]
        [Display(Name = "PatientName")]
        public string? PatientName { get; set; }


        [Required(ErrorMessage = "Hastanin soyadi bos olamaz")]
        [Display(Name = "PatientSurname")]
        public string? PatientSurname { get; set; }



        [Required(ErrorMessage = "Doktorun ismi bos olamaz")]
        [Display(Name = "DoctorName")]
        public string? DoctorName { get; set; }


        [Required(ErrorMessage = "Doktorun soyadi bos olamaz")]
        [Display(Name = "DoctorSurname")]
        public string? DoctorSurname { get; set; }


        [Display(Name = "AppointmentDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? AppointmentDate { get; set; }


        [RegularExpression(@"^[0-9]{2}:[0-9]{2}$", ErrorMessage = "Invalid time format")]
        public DateTime AppointmentTime {get; set; }


    }
}

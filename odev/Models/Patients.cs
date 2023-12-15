using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace odev.Models
{
    [Table("Patients")]
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }


        [Required(ErrorMessage ="Hastanin ismi bos olamaz")]
        [Display(Name ="PatientName")]
        public string? PatientName { get; set; }


        [Required(ErrorMessage = "Hastanin soyadi bos olamaz")]
        [Display(Name = "PatientSurname")]
        public string? PatientSurname { get; set; }


        [Required(ErrorMessage = "Hastanin telefon numarasi bos olamaz")]
        [Display(Name = "PatientPhoneNumber")]
        public string? PatientPhoneNumber { get; set; }


        [Required(ErrorMessage = "Hastanin dogum tarihi bos olamaz")]
        [Display(Name = "PatientBirthDate")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0: dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public string? PatientBirthDate { get; set;}


        [Required(ErrorMessage = "Hastanin cinsiyeti bos olamaz")]
        [Display(Name = "PatientGender")]
        [EnumDataType(typeof(Gender))]
        public string? PatientGender { get; set; }
    }
    public enum Gender
    {
        male,
        female
    }
}

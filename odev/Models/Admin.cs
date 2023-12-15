using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        [Required(ErrorMessage = "Mail bos olamaz")]
        [Display(Name = "AdminMail")]
        [DataType(DataType.EmailAddress)]
        public string? AdminMail { get; set; }

        [Required(ErrorMessage = "Sifre bos olamaz")]
        [Display(Name = "AdminPassword")]
        [DataType(DataType.Password)]
        public int AdminPassword { get; set; }

    }
}
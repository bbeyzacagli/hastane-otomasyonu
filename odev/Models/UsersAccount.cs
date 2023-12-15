using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odev.Models
{
    [Table("UsersAccount")]
    public class UsersAccount
    {
        [Key]
        public int UsersAccountID { get; set; }

        [Required(ErrorMessage = "Isim bos birakilamaz!")]
        [Display(Name = "FirstName")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Soyisim bos birakilamaz!")]
        [Display(Name = "Surname")]
        public string? Surname { get; set; }

        [Required(ErrorMessage = "Email adresi bos birakilamaz!")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Sifre bos birakilamaz!")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Sifreniz en az 6 karakterden olusmali!"), MaxLength(15, ErrorMessage = "Sifreniz en fazla 15 karakterden olusmali!")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Sifre bos birakilamaz!")]
        [Display(Name = "Sifreyi onaylayınız")]
        [Compare("Password", ErrorMessage = "Sifreler eslesmedi")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "Sifreniz en az 6 karakterden olusmali!"), MaxLength(15, ErrorMessage = "Sifreniz en fazla 15 karakterden olusmali!")]
        public string? CPassword { get; set; }
    }
}

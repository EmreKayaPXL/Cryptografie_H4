using System.ComponentModel.DataAnnotations;

namespace Cryptografie_H4.Models
{
    public class Login
    {
        
        [Required(ErrorMessage = "E-mail is verplicht.")]
        [EmailAddress(ErrorMessage = "Geef een geldig e-mailadres op.")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Wachtwoord is verplicht.")]
        [MinLength(8, ErrorMessage = "Je wachtwoord moet minstens 8 tekens hebben.")]
        public string Wachtwoord { get; set; }
    }
}

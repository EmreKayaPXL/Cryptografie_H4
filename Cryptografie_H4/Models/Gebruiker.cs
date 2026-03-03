using System.ComponentModel.DataAnnotations;

namespace Cryptografie_H4.Models
{
    public class Gebruiker
    {
        public int Id { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Geef een geldig e-mailadres op.")]
        public string Email { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Je wachtwoord moet minstens 8 tekens hebben.")]
        public string Wachtwoord { get; set; }
    }
}
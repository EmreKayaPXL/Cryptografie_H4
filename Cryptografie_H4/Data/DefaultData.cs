using Cryptografie_H4.Helpers;
using Cryptografie_H4.Models;

namespace Cryptografie_H4.Data
{
    public class DefaultData
    {
        public static IEnumerable<Gebruiker> gebruiker => GetGebruikers();

        private static IEnumerable<Gebruiker> GetGebruikers()
        {
            return new List<Gebruiker>()
            {
                new()
                {
                    Email = "Shirwan@test.be",
                    Wachtwoord = SHAHelper.MaakSha256Hash("User123!")
                },                
                new()             
                {                 
                    Email = "emre@test.be",
                    Wachtwoord = SHAHelper.MaakSha256Hash("User123!")
                },                
                new()             
                {                 
                    Email = "sefa@test.be",
                    Wachtwoord = SHAHelper.MaakSha256Hash("User123!")
                },                
                new()             
                {                 
                    Email = "sergey@test.be",
                    Wachtwoord = SHAHelper.MaakSha256Hash("User123!")
                },

            };
        }
    }
}

using System.Security.Cryptography;
using System.Text;

namespace Cryptografie_H4.Helpers
{
    public  class SHAHelper
    {
        public  string MaakSha256Hash(string wachtwoord) 
        {
            using var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(wachtwoord));
            return Convert.ToHexString(bytes);  // return: geeft een waarde terug en stopt de methode
        }
    }
}

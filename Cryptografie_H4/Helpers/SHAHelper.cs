using System.Security.Cryptography;
using System.Text;

namespace Cryptografie_H4.Helpers
{
    public  class SHAHelper
    {

            public static string MaakSha256Hash(string input)
            {
                if (string.IsNullOrWhiteSpace(input))
                    return string.Empty;

                using var sha = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha.ComputeHash(bytes);

                var sb = new StringBuilder();
                foreach (var b in hashBytes)
                    sb.Append(b.ToString("x2"));

                return sb.ToString();
            }
    }
}

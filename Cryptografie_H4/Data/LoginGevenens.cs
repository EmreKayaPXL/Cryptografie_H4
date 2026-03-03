using Cryptografie_H4.Models;

namespace Cryptografie_H4.Data
{
    public class LoginGevenens
    {
        public List<Login> Gebruikers { get; } = new List<Login>
        {
            new Login { Email = "Shirwan@test.be",   Wachtwoord = "User123!" },
            new Login { Email = "emre@test.be",   Wachtwoord = "User123!"  },
            new Login { Email = "sefa@test.be",   Wachtwoord = "User123!"  },
            new Login { Email = "sergey@test.be", Wachtwoord = "User123!"  }
        };
    }
}

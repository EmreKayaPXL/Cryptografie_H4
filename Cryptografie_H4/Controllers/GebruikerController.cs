using Cryptografie_H4.Data;
using Cryptografie_H4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cryptografie_H4.Controllers
{
    public class GebruikerController : Controller
    {

            private readonly LoginGevenens _loginGevenens;

            public GebruikerController(LoginGevenens loginGevenens)
            {
                _loginGevenens = loginGevenens;
            }

            [HttpGet]
            public IActionResult Login()
            {
                return View(new Login());
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Login model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            bool bestaat = _loginGevenens.Gebruikers.Any(g =>
                g.Email.Equals(model.Email, StringComparison.OrdinalIgnoreCase) &&
                g.Wachtwoord == model.Wachtwoord);

            if (!bestaat)
            {
                ModelState.AddModelError("", "Onjuiste e-mail of wachtwoord.");
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}

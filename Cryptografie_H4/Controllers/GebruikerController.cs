using Cryptografie_H4.Data;
using Cryptografie_H4.Helpers;
using Cryptografie_H4.Models;
using Cryptografie_H4.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Cryptografie_H4.Controllers
{
    public class GebruikerController : Controller
    {

            private readonly GebruikerDbContext _context;

            public GebruikerController(GebruikerDbContext context)
            {
            _context = context;
            }

            [HttpGet]
            public IActionResult Login()
            {
                return View(new Gebruiker());
            }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(Gebruiker model)
        {
            if (!ModelState.IsValid)
                return View(model);

            string ingegevenHash = SHAHelper.MaakSha256Hash(model.Wachtwoord);

            string emailNorm = (model.Email ?? "").Trim().ToUpper();

            bool bestaat = _context.Gebruiker.Any(g =>
                (g.Email ?? "").Trim().ToUpper() == emailNorm &&
                g.Wachtwoord == ingegevenHash);

            if (!bestaat)
            {
                ModelState.AddModelError("", "Onjuiste e-mail of wachtwoord.");
                return View(model);
            }

            return RedirectToAction("HomeIngelogd", "Home", new { email = model.Email });
        }

        [HttpGet]
        public IActionResult Logout()
        {
            return RedirectToAction("Login", "Gebruiker");
        }
    }
}

using Cryptografie_H4.Data;
using Cryptografie_H4.Helpers;
using Cryptografie_H4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cryptografie_H4.Controllers
{
    public class GebruikerController : Controller
    {

            private readonly GebruikerDbContext _loginGevenens;

            public GebruikerController(GebruikerDbContext loginGevenens)
            {
                _loginGevenens = loginGevenens;
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
            {
                return View(model);
            }

            bool bestaat = _loginGevenens.Gebruiker.Any(g =>
                g.Email.Equals(model.Email, StringComparison.OrdinalIgnoreCase) &&
                g.Wachtwoord == model.Wachtwoord);

            if (!bestaat)
            {
                ModelState.AddModelError("", "Onjuiste e-mail of wachtwoord.");
                return View(model);
            }

            return RedirectToAction("Index", "Home");



/*
            SHAHelper.MaakSha256Hash(model.Wachtwoord);


            SHAHelper SHA = new SHAHelper();
            SHA.MaakSha256Hash(model.Wachtwoord);*/
        }

        
    }
}

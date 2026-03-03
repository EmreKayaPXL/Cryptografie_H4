using Cryptografie_H4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cryptografie_H4.Controllers
{
    public class GebruikerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



        #region Login

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                

                if (model.Wachtwoord.Length > 7)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Je wachtwoord is niet lang genoeg");
                }
            }
            return View(model);
        }

        #endregion
    }
}

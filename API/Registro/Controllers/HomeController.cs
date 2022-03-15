using System.Net;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Models;
using Services.Services;

namespace Registro.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClass1 _class1;

        public HomeController(IClass1 class1)
        {
            _class1 = class1;
        }

        public IActionResult Index(ResponseLogin responseLoginsLogin)
        {
            ViewData["Name"] = responseLoginsLogin.FirstName;
            ViewData["Lasname"] = responseLoginsLogin.LastName;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(  UserResource userLoginResource)
        {
            _class1.AccountSuspensionMethod(userLoginResource);
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult Login(ResourceLogin resourceLogin)
        {
            var retuResponseLogin = _class1.AccountSuspensionMethod2(resourceLogin);
            return RedirectToAction("Index", retuResponseLogin);
        }
      
    }
}

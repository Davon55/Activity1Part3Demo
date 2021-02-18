using Activity1Part3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(UserModel model)
        {
            return View();
        }
    }
}

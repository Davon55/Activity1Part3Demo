using Activity1Part3.Models;
using Activity1Part3.Services.Business;
using Microsoft.AspNetCore.Mvc;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");
        

       //Get login
        [HttpGet]
        public IActionResult Index()
        {
            return View("Login");
        }
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            try
            {
                //put an item in the log
                logger.Info("Entering the login controller. Login Method");
                if (!ModelState.IsValid)
                    return View("Login");
                //Call the Security Service Authenticate() method from the Login() method
                //and save the results of the method call in a local method variable 
                SecurityService security = new SecurityService();
                Boolean success = security.Authenticate(user);

                if (success)
                {
                    logger.Info("Exit login controller. Login success");
                    return View("LoginSuccess", user);
                }
                else
                {
                    logger.Info("Exit login controller. Login failure");
                    return View("LoginFailure");
                }
            }
            catch (Exception e)
            {
                logger.Error("Exception " + e.Message);
                return Content("Exception in login", e.Message);
            }
           
          
            
        }
    }
}

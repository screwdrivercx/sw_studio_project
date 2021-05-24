using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sw_studio_project.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace sw_studio_project.Controllers
{
    public class AccountController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AccountController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)){
                return RedirectToAction("Login");
            }

            ClaimsIdentity identity = null;
            bool isAuthenticate = false;
            bool isAdmin = false;
            var Users = ReadUsers();

            foreach(var user in Users.users){
                if(user.username==username && user.password==password){
                    identity = new ClaimsIdentity(new[]{
                        new Claim(ClaimTypes.Name, username),
                        new Claim(ClaimTypes.Role, user.role)
                    }, CookieAuthenticationDefaults.AuthenticationScheme);
                    isAuthenticate = true;
                    isAdmin = user.role=="admin" ? true : false;
                }
            }

            if(isAuthenticate){
                var principle = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principle);
                if(!isAdmin)
                    return RedirectToAction("index","Home");
                else    
                    return RedirectToAction("Admin","Home");
            }
            return View();
        }
        public async Task LogOut(){
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme, new AuthenticationProperties{ RedirectUri="/"});
        }

        public IActionResult Register(){
            return View();
        }
        [HttpPost]
        public IActionResult Register(string firstName, string lastName, string username, string password){
            User newUser = new User{
                firstName = firstName, 
                lastName = lastName, 
                username = username, 
                password = password,
                role = "user"
            };
            var Users = ReadUsers();
            Users.users.Add(newUser);
            WriteUsers(Users);

            return RedirectToAction("Login","Account");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public Users ReadUsers()
        {
            return JsonConvert.DeserializeObject<Users>(System.IO.File.ReadAllText("./users.json"));
        }
        public void WriteUsers(Users model)
        {
            System.IO.File.WriteAllText("./users.json", JsonConvert.SerializeObject(model));
        }
    }
}

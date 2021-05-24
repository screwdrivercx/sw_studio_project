using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sw_studio_project.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace sw_studio_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authorize(Roles = "user")]
        public IActionResult Index()
        {
            var rooms = ReadRooms();
            return View(rooms);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            var users = ReadUsers();
            return View(users);
        }
        public IActionResult History(){
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public Rooms ReadRooms()
        {
            return JsonConvert.DeserializeObject<Rooms>(System.IO.File.ReadAllText("./rooms.json"));
        }
        public void WriteRooms(Rooms model)
        {
            System.IO.File.WriteAllText("./rooms.json", JsonConvert.SerializeObject(model));
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

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
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            ViewBag.hLog =  fileData;
            var rooms = ReadRooms();
            return View(rooms);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            var users = ReadUsers();
            return View(users);
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
        [HttpGet]
        public IActionResult History(){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            ViewBag.rentLog = fileData;
            return View();
        }
        [HttpPost]
        public IActionResult History(string objName,string timeStart,string timeEnd,int timeS, int timeE){
            var data = new RentLog();
            data.user= "joJo";
            data.objName = objName;
            data.SDate =timeStart;
            data.SHour = timeS;
            data.EDate =timeEnd;
            data.EHour = timeE;
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            fileData.Add(data);
            System.IO.File.WriteAllText("rentFilelog.json",JsonConvert.SerializeObject(fileData));
            ViewBag.rentLog = fileData;
            return View();
        }
        [HttpPost]
        public IActionResult deleteHistory(string user,string objName,string SDate,int SHour,string EDate, int EHour){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            for (var i = 0 ; i< fileData.Count;i++){
                if(fileData[i].user == user && fileData[i].objName == objName && fileData[i].SDate == SDate && fileData[i].SHour == SHour && fileData[i].EDate == EDate && fileData[i].EHour == EHour  ){
                    fileData.RemoveAt(i);
                    Console.WriteLine("Deleted");
                    break;
                }
            }
            System.IO.File.WriteAllText("rentFilelog.json",JsonConvert.SerializeObject(fileData));
            return RedirectToAction("History");
        }   

    }
    }
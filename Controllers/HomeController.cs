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
using System.Security.Claims;
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

            var blacklisted="";
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;  
                if (null != principal)  
                {  
                foreach (Claim claim in principal.Claims)  
                {  
                    Console.WriteLine("CLAIM TYPE: " + claim.Type + "; CLAIM VALUE: " + claim.Value + "</br>");  
                   blacklisted = claim.Value;
                }  
                } 
            Console.WriteLine(blacklisted);
            ViewBag.blacklisted = blacklisted;
            return View(rooms);
        }


        [Authorize(Roles = "admin")]
        public IActionResult Users(){
            var users = ReadUsers();
            return View(users);
        }
         [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            var rooms = ReadRooms();
            return View(rooms);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AdminHistory(){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            ViewBag.rentLog = fileData;
            fileData.Reverse();
            return View();
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
        [Authorize]
        public IActionResult History(){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            var httpContext = HttpContext;  
            
            var username ="";
            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;  
                if (null != principal)  
                {  
                foreach (Claim claim in principal.Claims)  
                {  
                    //Console.WriteLine("CLAIM TYPE: " + claim.Type + "; CLAIM VALUE: " + claim.Value + "</br>");  
                   username = claim.Value;
                   break;
                }  
                }  
            for(var i =0 ;i<fileData.Count;i++){
                if(fileData[i].user != username){
                    fileData.RemoveAt(i);
                    i-=1;
                }
            }
            fileData.Reverse();
            ViewBag.rentLog = fileData;
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult History(string objName,string timeStart,string timeEnd,int timeS, int timeE){
            var data = new RentLog();

            ClaimsPrincipal principal = HttpContext.User as ClaimsPrincipal;  
                if (null != principal)  
                {  
                foreach (Claim claim in principal.Claims)  
                {  
                    //Console.WriteLine("CLAIM TYPE: " + claim.Type + "; CLAIM VALUE: " + claim.Value + "</br>");  
                   data.user = claim.Value;
                   break;
                }  
                } 
                 
            data.objName = objName;
            data.SDate =timeStart;
            data.SHour = timeS;
            data.EDate =timeEnd;
            data.EHour = timeE;
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            fileData.Add(data);
            System.IO.File.WriteAllText("rentFilelog.json",JsonConvert.SerializeObject(fileData));
            for(var i =0 ;i<fileData.Count;i++){
                if(fileData[i].user != data.user){
                    fileData.RemoveAt(i);
                    i-=1;
                }
            }
            fileData.Reverse();
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
        [HttpPost]
        public IActionResult deleteAdminHistory(string user,string objName,string SDate,int SHour,string EDate, int EHour){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            for (var i = 0 ; i< fileData.Count;i++){
                if(fileData[i].user == user && fileData[i].objName == objName && fileData[i].SDate == SDate && fileData[i].SHour == SHour && fileData[i].EDate == EDate && fileData[i].EHour == EHour  ){
                    fileData.RemoveAt(i);
                    Console.WriteLine("Deleted");
                    break;
                }
            }
            System.IO.File.WriteAllText("rentFilelog.json",JsonConvert.SerializeObject(fileData));
            return RedirectToAction("AdminHistory");
        } 
        [HttpPost]
        public IActionResult EditRoom(int id, string roomName, string roomNumber, string accName, int accNumber){
            Rooms rooms = ReadRooms();
            Console.WriteLine(id.ToString()+ roomName+ roomNumber + accName+ accNumber.ToString());
            if(roomName == "" || roomNumber == "" || accName == "" || accNumber<0)
                return RedirectToAction("Admin");

            foreach(Room room in rooms.rooms){
                if(room.id == id){
                    room.name = roomName;
                    room.number = roomNumber;
                    room.accName = accName;
                    room.accNumber = accNumber;
                }
            }

            var count = 0;
            foreach(Room room in rooms.rooms){
                if(room.accName == accName){
                    count++;
                }
            }
            if(count<=1)
                WriteRooms(rooms);
            return RedirectToAction("Admin");
        }
        [HttpPost]
        public IActionResult Blacklist(string username){
            var users = ReadUsers();
            Console.WriteLine(username);
            foreach(User user in users.users){
                if(user.username == username){
                    if(user.blacklisted == true)
                        user.blacklisted = false;
                    else
                        user.blacklisted = true;
                }
            }
            WriteUsers(users);
            return RedirectToAction("Users");
        }

    }
    }
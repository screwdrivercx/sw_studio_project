using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sw_studio_project.Models;
using Newtonsoft.Json;

namespace sw_studio_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var roomObj = Read("./rooms.json");
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            ViewBag.hLog =  fileData;
            return View(roomObj);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public Root Read(string path)
        {
            return JsonConvert.DeserializeObject<Root>(System.IO.File.ReadAllText(path));
        }
        public void Write(Root model)
        {
            System.IO.File.WriteAllText("./rooms.json", JsonConvert.SerializeObject(model));
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
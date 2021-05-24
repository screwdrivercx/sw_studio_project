using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;  
using System.Net.Http;  
 using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using sw_studio_project.Models;

namespace sw_studio_project.Controllers
{

    public class CheckLogController : Controller
    {

        [HttpGet]
        
        public string Index(){
            return "Hello";
        }
        public List<int> checkDate(string Date,string objName){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            var checkList = new List<int>();
            var plusDefault = 0;
            var plusList = new List<int>();
            var chDate = DateTime.ParseExact(Date,"yyyy-MM-dd",null);
            for(var i =0; i< fileData.Count;i++){
                if (fileData[i].objName == objName){
                    var chLogStart = DateTime.ParseExact(fileData[i].SDate,"yyyy-MM-dd",null);
                    var chLogEnd = DateTime.ParseExact(fileData[i].EDate,"yyyy-MM-dd",null);
                    if(DateTime.Compare( chLogStart, chDate) < 0 ) {
                        if(DateTime.Compare( chDate, chLogEnd) < 0 ) {
                            plusDefault+=1;
                        }
                        else if(DateTime.Compare( chDate, chLogEnd) ==0){
                            plusList.Add(0);
                            plusList.Add(fileData[i].EHour);
                        }
                    }
                    else if(DateTime.Compare( chDate, chLogStart )==0){
                        if(DateTime.Compare( chDate, chLogEnd )==0){
                            plusList.Add(fileData[i].SHour);
                            plusList.Add(23);
                        }
                        else if(DateTime.Compare( chDate, chLogEnd ) < 0)  {
                            plusList.Add(fileData[i].SHour);
                            plusList.Add(fileData[i].EHour);
                        }
                    }
                }
            }
            for(var i =0;i< 24;i++){
                var indexValue = plusDefault;
                for (var j=0 ;j<plusList.Count;j+=2){
                    if(plusList[j] <= i && i <=plusList[j+1] ){
                        indexValue+=1;
                    }
                }
                checkList.Add(indexValue);
            }
            return  checkList;
        }
        public bool checkSubmit(string startD , int startH, string endD, int endH,int objNumber , string objName){
            var fileData = JsonConvert.DeserializeObject<List<RentLog>>(System.IO.File.ReadAllText("rentFilelog.json"));
            var chStart = DateTime.ParseExact(startD,"yyyy-MM-dd",null);
            var chEnd = DateTime.ParseExact(endD,"yyyy-MM-dd",null);
            while(chStart <= chEnd){
                var  a= checkDate(chStart.ToString("yyyy-MM-dd"),objName);
                for (var i =0 ; i< a.Count; i++)
                {   
                    if(chStart.ToString("yyyy-MM-dd") == startD){
                        if( i >=startH && a[i] >= objNumber ){
                            return false;
                        }
                    }
                    else if (chEnd.ToString("yyyy-MM-dd") == endD){
                        if(endH <=i && a[i] >= objNumber ){
                            return false;
                        }
                    }
                    else if(a[i] >= objNumber){
                        return false;
                    }
                }
                chStart =chStart.AddDays(1);
            }
            return true;
        }
        public string checkEnd(string Date){
            return  "HelloEnd";
        }

    }
}

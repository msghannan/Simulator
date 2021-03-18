using Simulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Simulator.ViewModels
{
    public class AllItemViewModel
    {
        public List<Valve> AllItemValve { get; set; }
        public List<Pipe> AllItemPipe { get; set; }
        public List<Pump> AllItemPump { get; set; }
        public List<Tank> AllItemTank { get; set; }

        public AllItemViewModel()
        {
            string jsonValve = File.ReadAllText(HttpContext.Current.Server.MapPath("~/DAL/Valve.json"));
            AllItemValve = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Valve>>(jsonValve);

            //string jsonPipe = File.ReadAllText("DAL/Pipe.json");
            //AllItemPipe = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pipe>>(jsonPipe);

            string jsonPump = File.ReadAllText(HttpContext.Current.Server.MapPath("~/DAL/Pump.json"));
            AllItemPump = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pump>>(jsonPump);

            string jsonTank = File.ReadAllText(HttpContext.Current.Server.MapPath("~/DAL/Tank.json"));
            AllItemTank = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Tank>>(jsonTank);
        }
    }
}
using Simulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Simulator.ViewModels
{
    public class ValveViewModel
    {
        public List<Valve> ValveList { get; set; }

        public ValveViewModel()
        {
            string json = File.ReadAllText("DAL/Valve.json");
            ValveList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Valve>>(json);
        }
    }
}
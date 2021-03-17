using Simulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Simulator.ViewModels
{
    public class PumpViewModel
    {
        public List<Pump> PumpList { get; set; }

        public PumpViewModel()
        {
            string json = File.ReadAllText("DAL/Pump.json");
            PumpList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pump>>(json);
        }
    }
}
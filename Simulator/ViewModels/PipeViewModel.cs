using Simulator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Simulator.ViewModels
{
    public class PipeViewModel
    {
        public List<Pipe> PipeList { get; set; }

        public PipeViewModel()
        {
            string json = File.ReadAllText("DAL/Pipe.json");
            PipeList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pipe>>(json);
        }

    }
}
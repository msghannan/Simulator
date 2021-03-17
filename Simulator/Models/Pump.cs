using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulator.Models
{
    public class Pump
    {
        public int Id { get; set; }
        public string PumpName { get; set; }
        public int Status { get; set; }
        public bool Activatable { get; set; }
        public List<Pipe> PumpPipeList { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulator.Models
{
    public class Valve
    {
        public int Id { get; set; }
        public string ValveName { get; set; }
        public int Status { get; set; }
        public bool Activatable { get; set; }
        public List<Pipe> ValvePipeList { get; set; }
    }
}
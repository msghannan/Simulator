using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simulator.Models
{
    public class Tank
    {
        public int Id { get; set; }
        public string TankName { get; set; }
        public int Status { get; set; }
        public bool ReadyForFill { get; set; }
        public bool ReadyForEmpty { get; set; }
        public bool FillTank { get; set; }
        public bool EmptyTank { get; set; }
    }
}
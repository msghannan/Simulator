using Simulator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Simulator.Controllers.Api
{
    public class VRCController : ApiController
    {
        Machine machine = new Machine();

        [HttpPost]
        public IHttpActionResult TogglePump1(int id)
        {
            machine.TogglePump1(id);

            return Ok("Pump " + id + " status has been changed");
        }

        public IHttpActionResult ToggleValve1(int id)
        {
            machine.ToggleValve1(id);

            return Ok("Valve " + id + " status has been changed");
        }
    }
}

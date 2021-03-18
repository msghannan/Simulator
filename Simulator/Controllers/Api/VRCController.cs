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

        public IHttpActionResult ToggleValve2(int id)
        {
            machine.ToggleValve2(id);

            return Ok("Valve " + id + " status has been changed");
        }

        public IHttpActionResult ToggleValve3(int id)
        {
            machine.ToggleValve3(id);

            return Ok("Valve " + id + " status has been changed");
        }

        public IHttpActionResult ToggleValve4(int id)
        {
            machine.ToggleValve4(id);

            return Ok("Valve " + id + " status has been changed");
        }

        public IHttpActionResult ToggleValve5(int id)
        {
            machine.ToggleValve5(id);

            return Ok("Valve " + id + " status has been changed");
        }

        public IHttpActionResult ReadyForEmpty(int id)
        {
            machine.ReadyForEmpty(id);

            return Ok();
        }

        public IHttpActionResult ReadyForFill(int id)
        {
            machine.ReadyForFill(id);

            return Ok();
        }
    }
}

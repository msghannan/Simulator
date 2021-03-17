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
        public IHttpActionResult TogglePump(int id)
        {
            machine.TogglePump1(id);

            return Ok("togglepump");
        }

        //[HttpGet]
        //public IHttpActionResult test()
        //{
        //    return Ok("Hi");
        //}
    }
}

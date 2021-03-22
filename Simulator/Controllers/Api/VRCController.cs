using Simulator.Models;
using Simulator.ViewModels;
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
        AllItemViewModel allItemViewModel = new AllItemViewModel();

        [HttpGet]
        public IHttpActionResult GetPump1Details(int id)
        {
            var pumpDetails = allItemViewModel.AllItemPump.Where(p => p.Id == id);
            int idCheck = 1;
            if(idCheck == id)
            {
                foreach(Pump p in allItemViewModel.AllItemPump)
                {
                    if(p.Id == id)
                    {
                        return Ok(pumpDetails);
                    }
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IHttpActionResult GetTank1Details(int id)
        {
            var tankDetails = allItemViewModel.AllItemTank.Where(t => t.Id == id);
            int idCheck = 1;
            if(idCheck == id)
            {
                foreach(Valve v in allItemViewModel.AllItemValve)
                {
                    if(v.Id == id)
                    {
                        return Ok(tankDetails);
                    }
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IHttpActionResult GetValve2Details(int id)
        {
            var valveDetails = allItemViewModel.AllItemValve.Where(v => v.Id == id);
            int idCheck = 2;
            if(idCheck == id)
            {
                foreach(Valve v in allItemViewModel.AllItemValve)
                {
                    if(v.Id == id)
                    {
                        return Ok(valveDetails);
                    }
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IHttpActionResult GetValve3Details(int id)
        {
            var valveDetails = allItemViewModel.AllItemValve.Where(v => v.Id == id);
            int idCheck = 3;
            if (idCheck == id)
            {
                foreach (Valve v in allItemViewModel.AllItemValve)
                {
                    if (v.Id == id)
                    {
                        return Ok(valveDetails);
                    }
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IHttpActionResult GetValve4Details(int id)
        {
            var valveDetails = allItemViewModel.AllItemValve.Where(v => v.Id == id);
            int idCheck = 4;
            if(idCheck == id)
            {
                foreach(Valve v in allItemViewModel.AllItemValve)
                {
                    if(v.Id == id)
                    {
                        return Ok(valveDetails);
                    }
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IHttpActionResult GetValve5Details(int id)
        {
            var valveDetails = allItemViewModel.AllItemValve.Where(v => v.Id == id);
            int idCheck = 5;
            if (idCheck == id)
            {
                foreach (Valve v in allItemViewModel.AllItemValve)
                {
                    if (v.Id == id)
                    {
                        return Ok(valveDetails);
                    }
                }
            }
            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult TogglePump1(int id)
        {
            foreach(Pump p in allItemViewModel.AllItemPump)
            {
                if(p.Id == id)
                {
                    machine.TogglePump1(id);
                    return Ok("Pump " + id + " status has been changed");
                }
            }

            return NotFound();
            
        }

        [HttpPost]
        public IHttpActionResult ToggleValve1(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if(v.Id == id)
                {
                    machine.ToggleValve1(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ToggleValve2(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {
                    machine.ToggleValve2(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ToggleValve3(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {
                    machine.ToggleValve3(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ToggleValve4(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {
                    machine.ToggleValve4(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ToggleValve5(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {
                    machine.ToggleValve5(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ReadyForEmpty(int id)
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                if (t.Id == id)
                {
                    machine.ReadyForEmpty(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }

        [HttpPost]
        public IHttpActionResult ReadyForFill(int id)
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                if (t.Id == id)
                {
                    machine.ReadyForFill(id);

                    return Ok("Valve " + id + " status has been changed");
                }
            }

            return NotFound();
        }
    }
}

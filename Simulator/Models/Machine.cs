using Newtonsoft.Json;
using Simulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Simulator.Models
{
    public class Machine
    {
        AllItemViewModel allItemViewModel = new AllItemViewModel();

        string PumpJsonPath = HttpContext.Current.Server.MapPath("~/DAL/Pump.json");
        string TankJsonPath = HttpContext.Current.Server.MapPath("~/DAL/Tank.json");
        string VentilJsonPath = HttpContext.Current.Server.MapPath("~/DAL/Valve.json");

        public void TogglePump1(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve.Where(v => v.Id == 3))
            {
                foreach (Pump pu in allItemViewModel.AllItemPump)
                {
                    if (pu.Id == id && v.Status == 1)
                    {
                        switch (pu.Status)
                        {
                            case 1:
                                pu.Status = 2;
                                break;
                            case 2:
                                pu.Status = 1;
                                break;
                        }

                        foreach (Pipe p in pu.PumpPipeList)
                        {
                            switch (p.Status)
                            {
                                case 1:
                                    p.Status = 2;
                                    break;
                                case 2:
                                    p.Status = 1;
                                    break;
                            }
                            break;
                        }
                        break;

                    }

                    else
                    {
                        pu.Activatable = false;
                        pu.Status = 2;
                        foreach (Pipe p in pu.PumpPipeList)
                        {
                            p.Status = 2;
                        }
                    }
                }
            }

            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(PumpJsonPath, output);
        }

        public void ToggleValve1(int id)
        {
            foreach (Tank t in allItemViewModel.AllItemTank.Where(t => t.Id == 1))
            {
                foreach (Valve v in allItemViewModel.AllItemValve)
                {
                    if (v.Id == id && t.ReadyForEmpty == true)
                    {
                        v.Activatable = true;

                        switch (v.Status)
                        {
                            case 1:
                                v.Status = 2;
                                break;
                            case 2:
                                v.Status = 1;
                                break;
                        }
                    }

                    else if (v.Id == id)
                    {
                        v.Activatable = true;

                        switch (v.Status)
                        {
                            case 1:
                                v.Status = 2;
                                break;
                            case 2:
                                v.Status = 1;
                                break;
                        }

                        foreach (Pipe p in v.ValvePipeList)
                        {
                            switch (p.Status)
                            {
                                case 1:
                                    p.Status = 2;
                                    break;
                                case 2:
                                    p.Status = 1;
                                    break;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }
    }
}
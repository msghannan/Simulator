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

        public void ToggleValve4(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                foreach (Tank t in allItemViewModel.AllItemTank)
                {
                    {
                        if (v.Id == id)
                        {
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
                            break;

                        }
                    }

                }
            }
            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void ToggleValve2(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {
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
                    break;

                }
            }

            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void ToggleValve3(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                if (v.Id == id)
                {

                    EnablePump();
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
                    break;

                }
            }

            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void ToggleValve5(int id)
        {
            foreach (Valve v in allItemViewModel.AllItemValve)
            {
                foreach (Tank t in allItemViewModel.AllItemTank.Where(t => t.Id == 1))
                {
                    if (v.Id == id)
                    {
                        if (v.Id == id && t.ReadyForFill == true)
                        {
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
                        else
                        {
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
                            break;
                        }


                    }
                }
            }

            //CallFillAndEmptyTank();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void ReadyForEmpty(int id)
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                foreach (Valve v in allItemViewModel.AllItemValve.Where(v => v.Id == 1 || v.Id == 2 || v.Id == 3 || v.Id == 5))
                {
                    foreach (Pipe p in v.ValvePipeList)
                    {
                        if (t.Id == id)
                        {
                            switch (v.Activatable)
                            {
                                case false:
                                    v.Activatable = true;
                                    EnableReadyToEmpty();
                                    break;
                                case true:
                                    v.Activatable = false;
                                    DisableReadyToEmpty();
                                    DisablePump();
                                    v.Status = 2;
                                    p.Status = 2;
                                    break;
                            }
                        }
                    }
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void ReadyForFill(int id)
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                foreach (Valve v in allItemViewModel.AllItemValve.Where(v => v.Id == 1 || v.Id == 4 || v.Id == 5))
                {
                    foreach (Pipe p in v.ValvePipeList)
                    {
                        if (t.Id == id)
                        {
                            switch (v.Activatable)
                            {
                                case false:
                                    v.Activatable = true;
                                    EnableReadyToFill();
                                    break;
                                case true:
                                    v.Activatable = false;
                                    DisableReadyToFill();
                                    v.Status = 2;
                                    p.Status = 2;
                                    break;
                            }
                        }
                    }
                }
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemValve, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(VentilJsonPath, output);
        }

        public void EnableReadyToEmpty()
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                t.ReadyForEmpty = true;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }

        public void DisableReadyToEmpty()
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                t.ReadyForEmpty = false;
                t.Status = 2;
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }


        public void EnableReadyToFill()
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                t.ReadyForFill = true;
            }
            FillTankSetting();
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }

        public void DisableReadyToFill()
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                t.ReadyForFill = false;
                t.Status = 2;
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }

        public void EnablePump()
        {
            foreach (Pump pu in allItemViewModel.AllItemPump.Where(pu => pu.Id == 1))
            {
                pu.Activatable = true;
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(PumpJsonPath, output);
        }

        public void DisablePump()
        {
            foreach (Pump pu in allItemViewModel.AllItemPump.Where(pu => pu.Id == 1))
            {
                pu.Activatable = false;
                pu.Status = 2;

                foreach (Pipe p in pu.PumpPipeList)
                {
                    p.Status = 2;
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemPump, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(PumpJsonPath, output);
        }

        public void FillTankSetting()
        {
            int numberOfOperationalValves = 0;
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                foreach (Valve v in allItemViewModel.AllItemValve)
                {
                    if (v.Id == 1 || v.Id == 4 || v.Id == 5)
                    {
                        if (v.Status == 1)
                        {
                            numberOfOperationalValves++;
                        }
                    }
                }
                if (numberOfOperationalValves == 3)
                {
                    t.Status = 1;
                }
                else
                {
                    t.Status = 2;
                }
            }

            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }

        public void EmptyTankSetting()
        {
            int numberOfOperationalValves = 0;
            int numberOfOperationalPumps = 0;
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                foreach (Pump p in allItemViewModel.AllItemPump)
                {
                    foreach (Valve v in allItemViewModel.AllItemValve)
                    {
                        if (v.Id == 1 || v.Id == 2 || v.Id == 3 || v.Id == 5 || p.Id == 1)
                        {
                            if (v.Status == 1)
                            {
                                numberOfOperationalValves++;
                            }
                            else if (p.Status == 1)
                            {
                                numberOfOperationalPumps++;
                            }
                        }
                    }
                    if (numberOfOperationalValves == 4 && numberOfOperationalPumps == 1)
                    {
                        t.Status = 1;
                    }
                    else
                    {
                        t.Status = 2;
                    }
                }
            }
            string output = JsonConvert.SerializeObject(allItemViewModel.AllItemTank, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(TankJsonPath, output);
        }

        public void CallFillAndEmptyTank()
        {
            foreach (Tank t in allItemViewModel.AllItemTank)
            {
                if (t.ReadyForFill == true)
                {
                    FillTankSetting();
                }
                else if (t.ReadyForEmpty == true)
                {
                    EmptyTankSetting();
                }
            }
        }
    }
}
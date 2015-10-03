using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStrongView.Controllers;
using MvcStrongView.Models;
/*Passing Data Using return View  or Passing Data to View*/

namespace MvcStrongView.Controllers
{
    public class S2Controller : Controller
    {
        // GET: S2
        public ActionResult Index()
        {
            List<Job> Jobs = new List<Job>();
            Job j1 = new Job() { ID = 1, Description = "Asp.net progrmammer", jobtitle = "progrmammer", Experiencereq = 1};
            Jobs.Add(j1);
            Job j2= new Job() { ID = 1, Description = "Asp.net jrDeveloper", jobtitle = "progrmammer", Experiencereq = 2};
            Jobs.Add(j2);
            Job j3=new Job() { ID = 1, Description = "Asp.netdeveloper", jobtitle = "progrmammer", Experiencereq = 2};
            Jobs.Add(j3);
            Job j4= new Job() { ID = 1, Description = "Asp.net sr developer", jobtitle = "progrmammer", Experiencereq = 4};
            Jobs.Add(j4);
            Job j5= new Job() { ID = 1, Description = "Asp.net sr progrsmmer", jobtitle = "progrmammer", Experiencereq = 4};
            Jobs.Add(j5);
            Job j6= new Job() { ID = 1, Description = "Asp.net manager", jobtitle = "progrmammer", Experiencereq = 5};
            Jobs.Add(j6);
            Job j7= new Job() { ID = 1, Description = "Asp.net director", jobtitle = "progrmammer", Experiencereq = 10};
            Jobs.Add(j7);
            return View(Jobs);
        }
    }
}
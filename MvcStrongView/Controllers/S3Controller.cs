using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStrongView.Controllers;
using MvcStrongView.Models;
/*Present Model data with scaffolding which automates CURD Operations based on our model class */
namespace MvcStrongView.Controllers
{
    public class S3Controller : Controller
    {
        // GET: S3
        public ActionResult Index()
        {
            List<Job> Jobs = new List<Job>();
            Job j1 = new Job() { Description = "Asp.net Progrmammer", jobtitle = "progrmammer", Experiencereq = 1 };
            Jobs.Add(j1);
            Job j2 = new Job() { Description = "Asp.net Sr Progrsmmer", jobtitle = "Senior Programmer", Experiencereq = 4 };
            Jobs.Add(j2);
            Job j3 = new Job() { Description = "Asp.net Jr Developer", jobtitle = " Junior Developer", Experiencereq = 2 };
            Jobs.Add(j3);
            Job j4 = new Job() { Description = "Asp.net Developer", jobtitle = "Developer", Experiencereq = 2 };
            Jobs.Add(j4);
            Job j5 = new Job() { Description = "Asp.net Sr Developer", jobtitle = "Senior Developer", Experiencereq = 4 };
            Jobs.Add(j5);
            Job j6 = new Job() { Description = "Asp.net Manager", jobtitle = "Manager", Experiencereq = 5 };
            Jobs.Add(j6);
            Job j7 = new Job() { Description = "Asp.net Director", jobtitle = "Director", Experiencereq = 10 };
            Jobs.Add(j7);
            return View(Jobs);
            /*Right Click add View and select List with Class Job 
             *automatic view Index.cshtml Gets generated
             *Scaffolding is a process or pattern that automates CURD based on our model classes.
             */
        }

        public ViewResult Show()
        {
            List<string> Countries = new List<string>();
            Countries.Add("India");
            Countries.Add("China");
            Countries.Add("Nepal");
            Countries.Add("Bangladesh");
            Countries.Add("Srilanka");
            ViewBag.Countries = new SelectList(Countries);
            return View();        
        }

        [HttpGet]// To distinguisg create methods  as no polymophism is supported
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Create ( Job J)
        {
            return Content("<h1>Record Added Http Post</h1>");
        }

    }
}
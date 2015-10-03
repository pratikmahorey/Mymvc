using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*Passing Data Using return View  or Passing Data to View*/
 
namespace MvcStrongView.Controllers
{
    public class S1Controller : Controller
    {
        // GET: S1 or Sv1
        public ActionResult Index()
        {
            List<string> Jobs = new List<string>();
            Jobs.Add("Asp.net Web froms");
            Jobs.Add("Asp.net Web Api");
            Jobs.Add("Azure Application");
            Jobs.Add("Hadoop Application");
            return View(Jobs);//1 of 3)
            //1-->(S1 controller) Provide return View 
         }
    }
}
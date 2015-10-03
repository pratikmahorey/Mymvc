using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcStrongView.Controllers;

namespace MvcStrongView.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public int Experiencereq { get; set; }
        public string  jobtitle { get; set; }
        //Go to controler and prepare data for model class
        //Than pass the same to view
        }
}
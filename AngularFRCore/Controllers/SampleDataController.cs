using System;
using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using FastReport.Web;
using System.IO;
using AngularFRCore.Models;

namespace AngularFRCore.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpGet("[action]")]

        public IActionResult ShowReport(string name)
        {
            WebReport WebReport = new WebReport();
            WebReport.Width = "1000";
            WebReport.Height = "1000";
            WebReport.Report.Load(String.Format("App_Data/{0}.frx", name));
            System.Data.DataSet dataSet = new System.Data.DataSet();
            dataSet.ReadXml("App_Data/nwind.xml");
            WebReport.Report.RegisterData(dataSet, "NorthWind");
            ViewBag.WebReport = WebReport;
            WebReport.Toolbar = new ToolbarSettings(){Position = Positions.Left,Exports = new ExportMenuSettings(){ExportTypes = Exports.Pdf}};

            return View();
        }
    }
}



        


    


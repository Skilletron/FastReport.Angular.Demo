using System;
using Microsoft.AspNetCore.Mvc;
using FastReport.Web;

namespace AngularFRCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleDataController : ControllerBase
    {
        [HttpGet("[action]")]
        public IActionResult ShowReport(string name)
        {
            WebReport WebReport = new WebReport();
            WebReport.Width = "1000";
            WebReport.Height = "1000";
            WebReport.Report.Load(String.Format("App_Data/{0}.frx", name)); // Load the report into the WebReport object
            System.Data.DataSet dataSet = new System.Data.DataSet(); // Create a data source
            dataSet.ReadXml("App_Data/nwind.xml"); // Open the xml database
            WebReport.Report.RegisterData(dataSet, "NorthWind"); // Registering the data source in the report
            ViewBag.WebReport = WebReport; // pass the report to View
            return View();
        }
    }
}

﻿using FastReport.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularFRCore.Models
{
    public class HomeModel
    {
        public WebReport WebReport { get; set; }
        public string[] ReportsList { get; set; }

    }
}
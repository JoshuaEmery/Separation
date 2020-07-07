using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Separation.Core.Models;
using Separation.Core.Services;

namespace Separation.Web.Controllers
{
    public class ReportsController : Controller
    {
        private IReportsService _reportsService;
        public ReportsController(IReportsService service)
        {
            _reportsService = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestReportService()
        {
            string output = "";
            Reports reports = _reportsService.GetById(44);
            output += reports.IncidentDate.ToString();
            return Content(output);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/Reportes")]
    public class ReportGeneratorController : Controller
    {
        [HttpGet]
        public IActionResult getPDF()
        {
            return View();
        }
        [HttpGet]
        public IActionResult getCSV()
        {
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/BitacoraGeneral")]
    public class GeneralBitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/BitacoraGeneral/Detalles")]
        public IActionResult Details(string id)
        {
            ViewData["id"] = id;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/BitacoraDeMovimientos")]
    public class WorkShifMovementsBitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
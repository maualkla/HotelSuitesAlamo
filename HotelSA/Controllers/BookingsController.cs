using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/Reservas")]
    public class BookingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Reservas/Formulario")]
        public IActionResult Form(int data, int id)
        {
            return View();
        }
    }
}
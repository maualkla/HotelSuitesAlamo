using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/Tarifas")]
    public class RatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Tarifas/Formulario")]
        public IActionResult Form(int action)
        {
            if(action == 1)
            {
                // Ver - Editar
                ViewData["action"] = 1;
            }
            else
            {
                // Crear
                ViewData["action"] = 2;
                action = 2;
            }
            return View("Form", action);
        }
    }
}
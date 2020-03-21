﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/Huespedes")]
    public class GuestsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Huespedes/Formulario")]
        public IActionResult Form(int data, string id)
        {
            ViewData["id"] = "N/A";
            ViewData["id"] = id;
            if (data != 1 && data != 2)
            {
                data = 0;
            }
            return View("Form", data);
        }
    }
}
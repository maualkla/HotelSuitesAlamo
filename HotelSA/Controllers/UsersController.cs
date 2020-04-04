﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    [Route("/Usuario")]
    public class UsersController : Controller
    {
        //[HttpGet]
        [Route("/Usuario/Inicio")]
        public IActionResult Index(String id, String data)
        {
            ViewData["id"] = id;
            ViewData["data"] = data;
            String datos = " Testa Values ";
            return View("index", datos);
        }
        // Metodo Default del controlador
        [Route("/Usuario")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("/Login")]
        public IActionResult Form()
        {
            return View();
        }
        [Route("/Registro")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
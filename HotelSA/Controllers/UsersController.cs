using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HotelSA.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Index(String id, String data)
        {
            ViewData["id"] = id;
            ViewData["data"] = data;
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace HotelSA.Controllers
{
    [Route("/Usuario")]
    public class UsersController : Controller
    {
/*
        private UserManager<IdentityUser> _UserManager;
        public UsersController(UserManager<IdentityUser> userManager)
        {
            _UserManager = userManager;
        }

*/
        
        
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
        public IActionResult Index(string parametros)
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
        [Route("/Registro/Nuevo")]
        public ActionResult CreateUser(string name, string email, string alias, string pass)
        {
            object resultado = "No entro";
            using (SqlConnection cn = new SqlConnection("Data Source=MAUALKLA;Initial Catalog=hosa;Integrated Security=True"))
            {
                cn.Open();
                String myQuery = "Select count(*) From usuarios Where alias = '" + alias + "' AND contra = '" + pass + "'";
                SqlCommand cmd = new SqlCommand(myQuery , cn);
                //SqlDataReader dr = cmd.ExecuteReader();
                int dr = (int)cmd.ExecuteScalar();

                //if (dr.Read())
                //{
                   resultado = dr;
                //}
            }


            if (ModelState.IsValid)
            {
                //var userList = _UserManager.Users.

                string parametros = resultado.ToString() + " Parametros: " + alias + " & " + pass;

                //if (alias == "Mauricio" && pass == "12345")
                //{
                //    return RedirectToAction("Index", "BitacoraGeneral");
                //}
                //else
                //{
                    return View("Index", parametros);
                //}
            }
            else
            {
                return View("Index");
            }
        }
    }
}
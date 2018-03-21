﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Converter.Models;

namespace Converter.Controllers
{
    public class HomeController : Controller
    {
        //This is the inital login form view
        public IActionResult Index()
        {
            return View();
        }

        //This is the rought for a succsessful login
        public IActionResult GoodLogin(LoginViewModel loginViewModel)
        {
            return View();
        }

        //This is the view for an unsucsessful login
        public IActionResult BadLogin(LoginViewModel loginViewModel)
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }       
    }
}

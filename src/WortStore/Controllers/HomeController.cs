﻿using Microsoft.AspNet.Mvc;

/*
Пока что язык и пользователь захаркожены
*/

namespace WortStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace ShopApp.Web.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
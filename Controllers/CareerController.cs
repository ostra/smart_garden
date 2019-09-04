using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace smart_garden.Controllers
{
    public class CareerController : Controller
    {
        public IActionResult Career()
        {
            return View();
        }
    }
}
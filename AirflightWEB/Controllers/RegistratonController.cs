using DTO.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AirflightWEB.Controllers
{
    public class RegistratonController : Controller
    {
        public IActionResult Index()
        {
            return View(new Registration());
        }
    }
}

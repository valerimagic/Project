using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL.DataContext;
using DTO.ViewModels;
using Microsoft.AspNetCore.Http;

namespace AirflightWEB.Controllers
{
    public class LoginController : Controller
    {
        private AirflightDbContext context;

        public LoginController()
        {
            context = new AirflightDbContext();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public IActionResult Index(UserViewModel model)
        {
            DAL.Entities.Airplanes userModelInDatabse = context.Airplane
                .Where(x => x.Model == model.Model && x.SerialNumber == model.SerialNumber).FirstOrDefault();

            if (userModelInDatabse != null)
            {
                HttpContext.Session.SetInt32("AirplaneID", userModelInDatabse.ID);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}

namespace AirflightWEB.Controllers
{
    using DAL.DataContext;
    using DAL.Entities;
    using DTO.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class RegistratonController : Controller
    {
        private AirflightDbContext context;

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Registration());
        }

        [HttpPost]
        public IActionResult Index(Registration model)
        {
            Airplanes airplane = new Airplanes()
            {
                Model = model.Model,
                SerialNumber = model.SerialNumber
            };
            RegistrationDetail reg_detail_entity = new RegistrationDetail()
            {
                FirstName = model.FirstName,
                LastName = model.Lastname,
                Email = model.Email,
                PhoneNumber = model.Phone,
                Airplane = airplane
            };
            this.context.Airplane.Add(airplane);
            this.context.RegistrationDetails.Add(reg_detail_entity);
            this.context.SaveChanges();
            return View(new Registration());
        }
    }
}

namespace AirflightWEB.Controllers
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DAL.DataContext;
    using DAL.Entities;
    using DTO.ViewModels;
    using Microsoft.AspNetCore.Mvc;

    public class FlightController : Controller
    {
        private AirflightDbContext context;

        public FlightController()
        {
            this.context = new AirflightDbContext();
        }

        public IActionResult Index()
        {
            Airplanes airplanes = this.context.Airplane.Include(x => x.Flights).First();
            List<FlightViewModel> list = new List<FlightViewModel>();

            foreach (var airplane in list)
            {
                FlightViewModel model = new FlightViewModel()
                {
                    DepartureDestination = airplane.DepartureDestination,
                    ArrivalDestination = airplane.ArrivalDestination
                };
                list.Add(model);
            }

            return View(list);
        }
    }
}

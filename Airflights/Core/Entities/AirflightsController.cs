using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DataContext;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Airflights.Core.Contracts;
using Airflights.Utilities.Messages;
//using Airflights.Models.Airplanes.Entities;
//using Airplanes = Airflights.Models.Airplanes.Entities.Airplanes;

namespace Airflights.Core
{
    public class AirflightsController : IAirFlights
    {
        private AirflightDbContext context;
        string[] input;

        public AirflightsController()
        {
            this.context = new AirflightDbContext();
        }

        //public List<Airplanes> SelectAirplane(string name)
        //{
        //    return this.context.Airplane.Include(x => x.Flights).ToList();
        //}

        //public List<Contacts> SelectAllContatcts()
        //{
        //    return this.context.Contacts.ToList();
        //}


        public string CreateAirplane(string model, string serialNumber)
        {
            var airplane = new Airplanes()
            {
                Model = model,
                SerialNumber = serialNumber
            };
            this.context.Airplane.Add(airplane);
            this.context.SaveChanges();

            return string.Format(OutputMessages.AirPlaneCreated, model);
        }

        public string RemoveAirplane()
        {
            throw new NotImplementedException();
        }

        public string CreateFlight(string flightNumber, string Departure, string arrival)
        {
            return string.Format(OutputMessages.AirPlaneCreated, flightNumber);
            //throw new NotImplementedException();
        }

        public string RemoveFlight()
        {
            throw new NotImplementedException();
        }

        public string CreateAirplane()
        {
            throw new NotImplementedException();
        }
    }
}

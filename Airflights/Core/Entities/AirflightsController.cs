namespace Airflights.Core
{
    using Airflights.Core.Contracts;
    using Airflights.Utilities.Messages;
    using DAL.DataContext;
    using DAL.Entities;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AirflightsController : IAirFlightsController
    {
        private AirflightDbContext context;
        string[] input;

        public AirflightsController()
        {
            this.context = new AirflightDbContext();
        }

        public List<Airplanes> SelectAirplane(string name)
        {
            return this.context.Airplane.Include(x => x.Flights).ToList();
        }

        public List<Flights> SelectAllFlight()
        {
            return this.context.Flight.ToList();
        }

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

        public string CreateFlight(string flightNumber, string departure, string arrival, int flightId)
        {
            Flights flight = new Flights()
            {
                FlightNumber = flightNumber,
                Departure = departure,
                Arrival = arrival,
                AirplaneId = this.context.Airplane.Where(x => x.ID == flightId).FirstOrDefault()
            };
            this.context.Flight.Add(flight);
            this.context.SaveChanges();

            return string.Format(OutputMessages.FlightCreated, departure, arrival);
        }

        public string RemoveFlight()
        {
            throw new NotImplementedException();
        }

        public string RemoveAirplane()
        {
            throw new NotImplementedException();
        }
    }
}

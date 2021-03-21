using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airflights.Core.Contracts
{
    public interface IAirFlightsController
    {
        string CreateAirplane(string model, string serialNumber);

        string CreateFlight(string flightNumber, string departure, string arrival, int flightId);
        string RemoveAirplane();

        string RemoveFlight();

        public List<Airplanes> SelectAirplane(string name);

        public List<Flights> SelectAllFlight();

    }
}

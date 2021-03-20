using System;
using System.Collections.Generic;
using System.Text;

namespace Airflights.Core.Contracts
{
    public interface IAirFlights
    {
        string CreateAirplane(string model, string serialNumber);

        string RemoveAirplane();

        string CreateFlight();

        string RemoveFlight();



    }
}

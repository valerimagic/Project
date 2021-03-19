using System;
using System.Collections.Generic;
using System.Text;

namespace Airflights.Core.Contracts
{
    public interface IAirFlights
    {
        string CreateAirplane();

        string RemoveAirplane();

        string CreateFlights();

        string RemoveFlights();



    }
}

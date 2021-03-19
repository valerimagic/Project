using System;
using Airflights.Core.Contracts;
using Airflights.Core.Entities;
using Airflights.IO;
using Airflights.IO.Contracts;

namespace Airflights
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IAirFlights controller = new AirflightsController();
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(controller, reader, writer);
            engine.Run();

            //IPlayer player = new Player();
        }
    }
}

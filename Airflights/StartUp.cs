namespace Airflights
{
    using Airflights.Core;
    using Airflights.Core.Contracts;
    using Airflights.Core.Entities;
    using Airflights.IO;
    using Airflights.IO.Contracts;
    using DAL.DataContext;
    using Microsoft.EntityFrameworkCore;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var db = new AirflightDbContext();

            db.Database.Migrate();

            IAirFlightsController controller = new AirflightsController();
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            Engine engine = new Engine(controller, reader, writer);
            engine.Run();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Airflights.Core.Contracts;
using Airflights.IO.Contracts;

namespace Airflights.Core.Entities
{
    public class Engine
    {

        private readonly IAirFlights controller;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IAirFlights airflightController, IReader reader, IWriter writer)
        {
            this.controller = airflightController;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {




        }

    }

}

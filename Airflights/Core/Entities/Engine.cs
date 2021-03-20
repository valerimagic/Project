using System;
using System.Collections.Generic;
using System.Text;
using Airflights.Core.Contracts;
using Airflights.IO.Contracts;
using Airflights.Core;
using Airflights.Core.Entities;

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
            string command = this.reader.ReadLine();

            while (command != "End")
            {



                try
                {

                    string[] input = command.Split();
                    var inputType = input[0];
                    string resultMessage = string.Empty;




                    if (inputType == "CreateAirplane")
                    {
                        resultMessage = this.controller.CreateAirplane(input[1], input[2]);
                    }

                    if (inputType == "CreateFlight")
                    {
                        resultMessage = this.controller.CreateFlight(input[1], input[2], input[3]);
                    }
















                    this.writer.WriteLine(resultMessage);
                }
                catch (Exception e)
                {
                    this.writer.WriteLine(e.Message);
                }


                command = this.reader.ReadLine();

            }


        }

    }

}

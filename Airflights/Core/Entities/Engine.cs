using System;
using System.Collections.Generic;
using System.Text;
using Airflights.Core.Contracts;
using Airflights.IO.Contracts;
using Airflights.Core;
using Airflights.Core.Entities;
using DAL.DataContext;
using DAL.Entities;


namespace Airflights.Core.Entities
{
    public class Engine
    {

        private readonly IAirFlightsController controller;
        private readonly IReader reader;
        private readonly IWriter writer;

        public Engine(IAirFlightsController airflightController, IReader reader, IWriter writer)
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
                        resultMessage = this.controller.CreateFlight(input[1], input[2], input[3], int.Parse(input[4]));
                    }

                    if (inputType == "SelectAirplane")
                    {
                        var element = this.controller.SelectAirplane(input[1]);
                        foreach (var item in element)
                        {
                            this.writer.WriteLine($"Airplane {item.Model}, SerialNumber {item.SerialNumber}");
                        }
                    }
                    if (inputType == "SelectAllFlight")
                    {
                        foreach (var item in this.controller.SelectAllFlight())
                        {
                            this.writer.WriteLine($"Flight with number {item.FlightNumber} from {item.Departure} to {item.Arrival}");
                        }
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

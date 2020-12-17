using System;
using System.Collections.Generic;

namespace DesignPatterns.Strategy
{
    public class StrategyExample
    {
        public List<Passenger> Passengers { get; set; }

        public StrategyExample()
        {
            Passengers = new List<Passenger>();

            Passenger passenger = new Passenger("John");
            passenger.SetTransportationStrategy(new TransportationByBus());
            Passengers.Add(passenger);
            passenger = new Passenger("Peter");
            Passengers.Add(passenger);
            passenger = new Passenger("Ann");
            passenger.SetTransportationStrategy(new TransportationByTaxi());
            Passengers.Add(passenger);
            passenger = new Passenger("Mary");
            passenger.SetTransportationStrategy(new TransportationByTrain());
            Passengers.Add(passenger);
        }


        public void Display()
        {
            Console.WriteLine("Strategy Pattern\nPassenger List\n");
            foreach (Passenger passenger in Passengers)
            {
                Console.WriteLine(passenger);
            }
        }
    }
}

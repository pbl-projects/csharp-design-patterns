using System;
namespace DesignPatterns.Strategy
{
    public class Passenger
    {
        public string Name { get; set; }
        public TransportationContext Transporation { get; set; }

        public Passenger(string name)
        {
            this.Name = name;
            Transporation = new TransportationContext();
        }


        public void SetTransportationStrategy(ITransportationStrategy strategy)
        {
            Transporation.TransportationStrategy = strategy;
        }


        public override string ToString()
        {
            return Name + ", " + Transporation.TransportationStrategy.Commute();
        }
    }
}

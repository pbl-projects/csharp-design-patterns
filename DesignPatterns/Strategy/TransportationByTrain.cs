using System;
namespace DesignPatterns.Strategy
{
    public class TransportationByTrain : ITransportationStrategy
    {
        public string Commute()
        {
            return "Commuting by train";
        }
    }
}

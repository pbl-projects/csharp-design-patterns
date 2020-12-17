using System;
namespace DesignPatterns.Strategy
{
    public class TransportationByBus : ITransportationStrategy
    {
        public string Commute()
        {
            return "Commuting by bus";
        }
    }
}

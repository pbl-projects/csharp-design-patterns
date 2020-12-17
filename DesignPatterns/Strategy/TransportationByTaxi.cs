using System;
namespace DesignPatterns.Strategy
{
    public class TransportationByTaxi : ITransportationStrategy
    {
        public string Commute()
        {
            return "Commuting by taxi";
        }
    }
}

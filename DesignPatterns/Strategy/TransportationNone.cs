using System;
namespace DesignPatterns.Strategy
{
    public class TransportationNone : ITransportationStrategy
    {
        public string Commute()
        {
            return "No Commuting selected";
        }
    }
}

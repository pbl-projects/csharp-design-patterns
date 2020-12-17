using System;
namespace DesignPatterns.Strategy
{
    public class TransportationContext
    {
        public ITransportationStrategy TransportationStrategy { get; set; }

        public TransportationContext()
        {
            TransportationStrategy = new TransportationNone();
        }
    }
}

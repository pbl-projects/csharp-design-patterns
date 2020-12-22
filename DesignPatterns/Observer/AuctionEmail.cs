using System;
namespace DesignPatterns.Observer
{
    public class AuctionEmail : IAuctionListener
    {
        public void BidSet(int bid)
        {
            Console.WriteLine("Sending email of {0} bid to agent", bid);
        }
    }
}

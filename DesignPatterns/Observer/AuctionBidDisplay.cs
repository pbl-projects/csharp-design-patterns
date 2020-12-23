using System;
namespace DesignPatterns.Observer
{
    public class AuctionBidDisplay : IAuctionObserver
    {
        public void BidSet(int bid)
        {
            Console.WriteLine("A bid of {0} is set", bid);
        }
    }
}

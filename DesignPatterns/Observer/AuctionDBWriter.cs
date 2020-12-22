using System;
namespace DesignPatterns.Observer
{
    public class AuctionDBWriter : IAuctionListener
    {
        public void BidSet(int bid)
        {
            Console.WriteLine("Saving a bid of {0} to the database", bid);
        }
    }
}

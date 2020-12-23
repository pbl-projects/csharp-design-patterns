using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Auction
    {
        public List<IAuctionObserver> AuctionObservers { get; set; }

        public Auction()
        {
            AuctionObservers = new List<IAuctionObserver>();
        }

        public void AddAuctionListener(IAuctionObserver Listener)
        {
            AuctionObservers.Add(Listener);
        }

        public void RemoveAuctionListener(IAuctionObserver Listener)
        {
            AuctionObservers.Remove(Listener);
        }

        public void DoBid()
        {
            int bid;
            Console.Write("Bid: ");
            bid = Int32.Parse(Console.ReadLine());

            foreach(IAuctionObserver Observer in AuctionObservers)
            {
                Observer.BidSet(bid);
            }
        }
    }
}

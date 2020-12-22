using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Auction
    {
        public List<IAuctionListener> AuctionListeners { get; set; }

        public Auction()
        {
            AuctionListeners = new List<IAuctionListener>();
        }

        public void AddAuctionListener(IAuctionListener Listener)
        {
            AuctionListeners.Add(Listener);
        }

        public void RemoveAuctionListener(IAuctionListener Listener)
        {
            AuctionListeners.Remove(Listener);
        }

        public void DoBid()
        {
            int bid;
            Console.Write("Bid: ");
            bid = Int32.Parse(Console.ReadLine());

            foreach(IAuctionListener Listener in AuctionListeners)
            {
                Listener.BidSet(bid);
            }
        }
    }
}

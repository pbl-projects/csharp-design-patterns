﻿using System;
namespace DesignPatterns.Observer
{
    public class AuctionLog : IAuctionObserver
    {
        public void BidSet(int bid)
        {
            Console.WriteLine("Logging {0} bid to log file", bid);
        }
    }
}

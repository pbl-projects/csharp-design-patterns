using System;
namespace DesignPatterns.Observer
{
    public interface IAuctionObserver
    {
        public void BidSet(int bid);
    }
}

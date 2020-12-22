using System;
namespace DesignPatterns.Observer
{
    public interface IAuctionListener
    {
        public void BidSet(int bid);
    }
}

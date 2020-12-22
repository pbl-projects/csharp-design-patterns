using System;
namespace DesignPatterns.Observer
{
    public class AuctionLoader
    {
        public AuctionLoader()
        {
            Auction auction = new Auction();
            auction.AddAuctionListener(new AuctionEmail());
            auction.AddAuctionListener(new AuctionDBWriter());
            auction.AddAuctionListener(new AuctionLog());
            auction.AddAuctionListener(new AuctionBidDisplay());

            auction.DoBid();
        }
    }
}

using System;
namespace DesignPatterns.Observer
{
    public class WrongAuction
    {
        public WrongAuction()
        {
            
        }

        public void LogBid(int bid)
        {
            Console.WriteLine("Logging {0} bid to log file", bid);
        }

        public void EmailBid(int bid)
        {
            Console.WriteLine("Sending email of {0} bid to agent", bid);
        }

        public void SaveBidToDb(int bid)
        {
            Console.WriteLine("Saving a bid of {0} to the database", bid);
        }

        public void DisplayBid(int bid)
        {
            Console.WriteLine("A bid of {0} is set", bid);
        }


        public void DoBid()
        {
            int bid;
            Console.Write("Bid: ");
            bid = Int32.Parse(Console.ReadLine());

            LogBid(bid);
            EmailBid(bid);
            SaveBidToDb(bid);
            DisplayBid(bid);
        }
    }
}

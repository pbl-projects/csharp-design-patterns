using System;
using DesignPatterns.Observer;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static string menu()
        {
            Console.WriteLine("\n\nSELECT PATTERN");
            Console.WriteLine("1. Strategy");
            Console.WriteLine("2. Observer");
            Console.WriteLine("0. Exit");
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            string option = "";

            do
            {
                option = menu();

                switch(option)
                {
                    case "1":
                        StrategyExample strategy = new StrategyExample();
                        strategy.Display();
                        break;
                    case "2":
                        AuctionLoader loader = new AuctionLoader();
                        break;
                    case "0":
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
                
            } while (option != "0");
        }
    }
}

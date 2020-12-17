using System;
using DesignPatterns.Strategy;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            StrategyExample strategy = new StrategyExample();
            strategy.Display();
        }
    }
}

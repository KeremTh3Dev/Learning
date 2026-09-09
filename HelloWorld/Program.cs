
using Learning.Homeworks;
using Learning.Homeworks.IATAFlightDispatchSystem;
using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var FlightDispatcher = new FlightDispatcher();
            var THY737 = new Aircraft();

            THY737.TailNumber = "TC-JGL";
            THY737.Model = "Boeing 737-300";

            FlightDispatcher.printManifest(THY737);
        }
    }
}

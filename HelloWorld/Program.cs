
using Learning.Homeworks;
using Learning.Homeworks.IATAFlightDispatchSystem;
using System;

namespace Learning
{
    class Program
    {
        public enum PlaneType
        {
            NarrowBody = 1,
            WideBody = 2

        }
        static void Main(string[] args)
        {
            var planeId = console.RegisterAs<int>("planeId:");
             Console.WriteLine((PlaneType)planeId);
        }
    }
}
using Learning.Learning;
using System;
using System.Threading;
namespace Learning
{
    class Program
    {
       
        static void Main(string[] args)
        {
            while (true)
            {
                Thread.Sleep(1000);
                EmergencySituations.randomEmergency();
            }
        }
    }
}






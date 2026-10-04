using System;
namespace Learning.Learning
{
    public class EmergencySituations
    {
        public enum Emergencies
        {
            EngineFire,
            EngineLeak,
            OxygenLeak,
            EngineOverheat
        }
        public static void randomEmergency()
        {
            var random = new Random();
            var emergencyIndex = random.Next(0, 4);
            var currentEmergency = (Emergencies)emergencyIndex;

            switch (currentEmergency)
            {
                case Emergencies.EngineFire:
                    Console.WriteLine("Motor alev aldı!");
                    break;

                case Emergencies.EngineLeak:
                    Console.WriteLine("Yakıt sızıntısı var!");
                    break;

                case Emergencies.OxygenLeak:
                    Console.WriteLine("Oksijen sızıyor!");
                    break;

                case Emergencies.EngineOverheat:
                    Console.WriteLine("Motor aşırı ısındı!");
                    break;

                default:
                    Console.WriteLine("Sistemler normal.");
                    break;
            }
        }
    }
}

using System;

namespace Learning.Homeworks.BeginnerExercises
{
    public class SpeedCamera
    {
        public static void EvaluateSpeed()
        {
            Console.Write("Enter the speed limit: ");
            int limitSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the car's speed: ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            int speedDifference = carSpeed - limitSpeed;
            int demeritPoints = speedDifference / 5;

            
            if (demeritPoints > 0 && demeritPoints <= 12)
                Console.WriteLine("You have exceeded the speedlimit. Demerit points: {0}", demeritPoints);
            else if (demeritPoints > 12)
                Console.WriteLine("License suspended. Demerit points: {0}", demeritPoints);
            else
                Console.WriteLine("Ok");
        }
    }
}

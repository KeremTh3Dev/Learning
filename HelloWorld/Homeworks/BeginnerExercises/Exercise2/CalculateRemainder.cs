using System;
namespace Learning.Homeworks.BeginnerExercises.Exercise2
{
    public class CalculateRemainder
    {
        public static void CalcOneToHundred()
        {
            int count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

using System;
namespace Learning.Homeworks.BeginnerExercises.Exercise2
{
    public class CalculateFactorial
    {
        public static void calculate()
        {
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            Console.WriteLine("{0}! = {1}", number, result);
        }
    }
}





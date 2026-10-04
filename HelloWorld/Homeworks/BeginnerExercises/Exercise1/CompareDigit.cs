using System;

namespace Learning.Homeworks.BeginnerExercises
{
    public class CompareDigit
    {
        public static void GetMax()
        {
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
                Console.WriteLine("First number is bigger. ");
            else if (number2 > number1)
                Console.WriteLine("Second number is bigger. ");
            else
                Console.WriteLine("Numbers are equal. ");
        }
    }
}

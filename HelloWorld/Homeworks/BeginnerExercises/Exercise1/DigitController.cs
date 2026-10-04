using System;

namespace Learning.Homeworks.BeginnerExercises
{
    public class DigitController
    {
        public static void EnterDigit()
        {
            Console.Write("Enter a digit between one to ten: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if(number>=1 && number<=10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}

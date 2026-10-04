using System;
namespace Learning.Homeworks.BeginnerExercises.Exercise2
{
    public class ConsoleApp1
    {
        public static void askUser()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Enter a number or type ok to exit: ");
                string input = Console.ReadLine();
                if (input == "ok")
                    break;
                int number = Convert.ToInt32(input);
                sum+= number;
                
            }
            Console.WriteLine(sum);
        }
    }
}

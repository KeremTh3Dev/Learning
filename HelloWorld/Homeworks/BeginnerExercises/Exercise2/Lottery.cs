using System;

namespace Learning.Homeworks.BeginnerExercises.Exercise2
{
    public class Lottery
    {
        public static void Play()
        {
            var random = new Random();
            var luckyNumber = random.Next(1, 11);


            for (int i = 0; i < 4; i++) 
            {
                Console.Write("Sayıyı tahmin edin: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input == luckyNumber)
                {
                    Console.WriteLine("You won");
                    return; 
                }
            }
            Console.WriteLine("You lost");
        }
    }
}
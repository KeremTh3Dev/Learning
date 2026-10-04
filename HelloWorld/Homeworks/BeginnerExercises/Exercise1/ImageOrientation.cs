using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning.Homeworks.BeginnerExercises
{
    public class ImageOrientation
    {
        public static void CheckOrientation()
        {
            Console.WriteLine("Please enter width and height");
            Console.Write("width: ");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.Write("height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height > width)
                Console.WriteLine("This is a portrait resolution. ");
            else if (width > height)
                Console.WriteLine("This is a landscape resolution. ");
            else
                Console.WriteLine("This is a square resolution. ");
        }
    }
}

using System;


namespace Learning.Homeworks
{
    public static class console
    {
        /* amaç basit, 

          var userId = console.RegisterAs{type}(messageToUser)

          şeklinde kolayca kullanıcıya konsoldan veri kaydetmesini sağlayan bir metot oluşturmak.
         bir de try-catch ile kullanıcı başka bir input verirse hata kodu ver */


        public static T RegisterAs<T>(string messageToUser)
        {
            while (true)
            {
                Console.Write($"{messageToUser} ");
                string input = Console.ReadLine();

                try
                {
                    return (T)Convert.ChangeType(input, typeof(T));
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatException: Invalid format, try again.");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("OverflowException: Out of range, try again.");
                }
            }
        }





        /*
        public static byte RegisterAsByte(string messageToUser)
        {
            Console.Write(messageToUser);
            return byte.Parse(Console.ReadLine());
        }

        public static int RegisterAsInt(string messageToUser)
        {
            Console.Write(messageToUser); //AYRICA HER TIRNAK İÇİ YAZIMDA BOŞLUK BIRAKMAKLA UĞRAŞMAMAK İÇİN MESSAGETOUSER KISMININ YANINA BOŞLUK OPERATORU KÖY
            return int.Parse(Console.ReadLine());
        }

        public static double RegisterAsDouble(string messageToUser)
        {
            Console.Write(messageToUser);
            return double.Parse(Console.ReadLine());
        }

        public static string RegisterAsString(string messageToUser)
        {
            Console.Write(messageToUser);
            return Console.ReadLine();
        }
        */
    }
}

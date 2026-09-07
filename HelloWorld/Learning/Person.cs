using System;

namespace Learning
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName); //bad syntax 

            //or you can simply use this, in order to maintain clean code.

            var fullName = string.Format("My name is {0} {1}", FirstName, LastName); //good syntax
            Console.WriteLine(fullName);
        }
    }
}

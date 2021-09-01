using System;

namespace HowOldAreYou
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What Is Your Name?");
            //Readline() to read the user input from the console
            string UserName = Console.ReadLine();
            Console.WriteLine("Hello," + UserName);
            Console.Read();
            Console.WriteLine("How Old Are You? Enter digits only");
            int Age = Int32.Parse(Console.ReadLine());
            int YearOfBirth = 2021 - Age;
            //Console.WriteLine("You Were Born In " + YearOfBirth);
            Console.WriteLine($"You Were Born In {YearOfBirth}");

        }
    }
}

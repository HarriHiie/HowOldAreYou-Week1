using System;

namespace FullName
{
    class Program
    {
        static void Main(string[] args)
        {
            //step 1. programm küsib kasutaja käest kasutaja eesnime
            //step 2. programm küsib kasutaja käest kasutaja perekonnanime
            //step 3. programm tervitab kasutajat kasutades neid andmeid
            Console.WriteLine("What Is Your Name?");
            //Readline() to read the user input from the console
            string UserName1 = Console.ReadLine();
            Console.WriteLine("What Is Your Last Name?");
            //Readline() to read the user input from the console
            string UserName2 = Console.ReadLine();
            Console.WriteLine("Hello," + UserName1 + UserName2 );
        }
    }
}

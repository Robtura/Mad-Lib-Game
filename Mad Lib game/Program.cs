using System;
using System.Drawing;

namespace Mad_Lib_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, celebrity;

            Console.Write("-------------------------------\n");
            Console.Write("----------Mad Lib Game---------\n");
            Console.Write("-------------------------------\n");

            Console.WriteLine("");

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("");

            Console.Write("-------------------------------\n");

            Console.WriteLine("");

            Console.WriteLine("Roses are " + color );
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrity);

            Console.WriteLine("");
            Console.Write("---Press any key to close------\n");

            Console.ReadKey();

        }
    }
}

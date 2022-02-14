using System;

namespace Functies_return_Bronze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(myName());
        }

        static string myName()
        {
            string naam = "Mike";
            return naam;
        }
    }
}

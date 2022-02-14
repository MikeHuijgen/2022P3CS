using System;

namespace Tijd_op_het_scherm_Silver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            string datumTijd = "HH:mm:ss";
            Console.WriteLine(time.ToString(datumTijd));
        }
    }
}

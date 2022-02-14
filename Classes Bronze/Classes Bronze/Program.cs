using System;

namespace Classes_Bronze
{
    class RekenMachine
    {
        public void Optellen()
        {
            Console.WriteLine("geef 2 cijfers die worden dan worden opgeteld !");

            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int antwoordOptellen = getal1 + getal2;

            Console.WriteLine(getal1 + "+" + getal2 + "=" + antwoordOptellen);
        }

        public void VermenigVuldigd()
        {
            Console.WriteLine("geef 3 cijfers die dan worden VermenigVuldigd !");

            int getal1 = Convert.ToInt32(Console.ReadLine());
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int getal3 = Convert.ToInt32(Console.ReadLine());
            int antwoordVermenigVuldigd = getal1 * getal2 * getal3;

            Console.WriteLine(getal1 + "*" + getal2 + "*" + getal3 +"=" + antwoordVermenigVuldigd);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RekenMachine machine = new RekenMachine();

            machine.Optellen();
            machine.VermenigVuldigd();
        }
    }
}

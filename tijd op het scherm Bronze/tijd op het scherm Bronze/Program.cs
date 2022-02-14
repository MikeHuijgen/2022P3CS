using System;
using System.Timers;

namespace tijd_op_het_scherm_Bronze
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            
            Timer tmer = new Timer(1000);
            tmer.Elapsed += Tmer_Elapsed;
            tmer.Enabled = true;
            tmer.AutoReset = true;
            tmer.Start();
            
            Console.ReadKey();         
        }

        private static void Tmer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime time = DateTime.Now;
            string datumTijd = "HH:mm:ss";
            Console.WriteLine(time.ToString(datumTijd));
        }
    }
}

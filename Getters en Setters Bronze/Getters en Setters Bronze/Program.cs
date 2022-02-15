using System;

namespace Getters_en_Setters_Bronze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HealthPlayer healthPlayer = new HealthPlayer();
            Console.WriteLine(healthPlayer.Health);
        }
    }

    class HealthPlayer
    {
        private int healthPoints = 100;
        
        public HealthPlayer()
        {
            Health = healthPoints;
        }

        public int Health
        {
            get { return healthPoints; }
            set { healthPoints = 150; }
            
        }
           
    }

}

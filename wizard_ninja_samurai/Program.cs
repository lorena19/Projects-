using System;
using wizard_ninja_samurai.Models;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fight to the Death");
            Wizard Harry = new Wizard("Harry");
            Human Larry = new Human("Larry");
            Ninja Norris = new Ninja("Norris");
            Samuari Suki = new Samuari("Suki"); 
            Larry.Attack(Harry); 
            Norris.Attack(Suki); 
            Suki.Attack(Harry); 
            Harry.Attack(Norris); 
            Suki.Meditate(); 
            Norris.Steal(Harry); 
            Harry.Heal(); 
        }
    }
}

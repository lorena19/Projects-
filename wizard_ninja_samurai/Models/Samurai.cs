using System; 

namespace wizard_ninja_samurai.Models
{
    public class Samuari : Human
    {
        public Samuari(string name) : base(name)
        {
            Health = 200; 
        }

        public void Meditate()
        {
            Health = 200; 
            System.Console.WriteLine("{0} meditated and is now fully healed. Health is now {1}", Name, Health);
        }

        public override int Attack(Human target)
        {
            if(target.Health < 50)
            {
                target.Health = 0;  
            }
            Console.WriteLine("{0} Health is now {1}", Name, Health); 
            return base.Attack(target); 
        }
    }
}
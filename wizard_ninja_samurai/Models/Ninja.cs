using System; 

namespace wizard_ninja_samurai.Models
{
    public class Ninja : Human
    {
        public Ninja(string name) : base(name)
        {
            Dexterity = 175; 
        }

        public void Steal(Human target)
        {
            target.Health -= 5; 
            Health += 5; 
            Console.WriteLine("{0} health is now {1}.", Name, Health); 
        }

        public override int Attack(Human target)
        {
            base.Attack(target); 

            int dmg = 5 * Dexterity; 
            target.Health -= dmg;
            Console.WriteLine("{0} Health is now {1}", Name, Health); 
            return target.Health;
        }
    }
}
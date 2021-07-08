using System; 

namespace wizard_ninja_samurai.Models
{
    public class Wizard : Human
    {

        
        public Wizard(string name) : base(name)
        {
            Health = 50; 
            Intelligence = 25; 
        }

    
        public void Heal()
        {
            Health += 10 * Intelligence; 
        }

        public override int Attack(Human target)
        {
            base.Attack(target);

            int dmg = 5 * Intelligence; 
            target.Health -= dmg;
            Console.WriteLine("{0} Health is now {1}", Name, Health); 
            return target.Health; 
            

        }
    }
}
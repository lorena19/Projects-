using System; 

namespace wizard_ninja_samurai.Models
{
    public class Human
    {
        public string Name; 
        public int Strength; 
        public int Intelligence; 
        public int Dexterity; 
        public int Health;

        public Human(string name)
        {
            Name = name;  
        }

        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name; 
            Strength = str; 
            Intelligence = intel; 
            Dexterity = dex; 
            Health = hp; 
        }

        public virtual int Attack(Human target)
        {
            int dmg = Strength * 3; 
            target.Health -= dmg; 
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            return target.Health; 
        }
    }
}
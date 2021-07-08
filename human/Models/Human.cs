using System;

namespace Human.Models
{
    public class Humans
    {
        // Fields for Humancopy
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;

    public int Health {
        get {return health;}
    }
    private int health;

    public Humans(string name)
    {
        Name = name;
        Strength = 3; 
        Intelligence = 3; 
        Dexterity = 3; 
        health = 100; 
        
    }
    
    public Humans(string name, int str, int intel, int dex)
    {
        Name = name; 
        Strength = str; 
        Intelligence = intel; 
        Dexterity = dex; 
    }
    
    public void CurrentHealth()
    {
        Console.WriteLine(health);
    }

    // Build Attack method
    public Humans Attack(Humans target)
    {
        int damg = Strength * 5;
        target.health -= damg;
        Console.WriteLine($"ATTACK! {Name} attacked {target.Name} and they lost {damg} points to their health!");
        Console.WriteLine($"Current Status: {Health} ");

        return this; 
    }

    }
}
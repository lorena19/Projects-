using System;
using Human.Models;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human!");

            Humans Lorena = new Humans("Lorena", 60, 3, 3); 
            Humans Jamir = new Humans("Jamir"); 

            Lorena.Attack(Jamir); 
        }
    }
}

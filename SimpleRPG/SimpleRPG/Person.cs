using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleRPG
{
    public class Person
    {
        public string name;
        public int attack;
        public int health;

        public Person(string _name, int _attack, int _health)
        {
            name = _name;
            attack = _attack;
            health = _health;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0}Name:", name);
            Console.WriteLine("");
            Console.WriteLine("Attack: {0}", attack);
            Console.WriteLine("Health: {0}", health);
        }

        public void NormalAttack(Person target)
        {
            target.health -= attack;
        }
    }
}

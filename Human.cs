using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        public int health
        {
            get {return Health;}
        }
        public Human (string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health =100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name=name;
            Strength=strength;
            Intelligence=intelligence;
            Dexterity=dexterity;
            Health=health;
        }
        public virtual int Attack (Human target)
        {
            int dmg = Strength* 3;
            target.Health -=dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge!");
            return target.Health;
        }
    }
}
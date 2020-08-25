using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Ninja : Human
    {
        public Ninja (string name) :base(name)
        {
            base.Dexterity=175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int critChance= rand.Next(0,100);
            int dmg=0;
            if (critChance<20)
            {
                dmg=(5*Dexterity) +10;
                Console.WriteLine("Critical Hit +10 damage!");
            }
            else
            {
                dmg=(5*Dexterity);
            }
            target.Health -=dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge!");
            return target.Health;
        }
        public void Steal(Human target)
        {
            if (target.Health>5)
            {
                target.Health-=5;
                Health+=5;
                Console.WriteLine($"{Name} steals 5 health from {target.Name}");
            }
            
        }
    }
}
using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Samurai :Human 
    {
        public Samurai(string name) :base(name)
        {
            base.Health=200;
        }
        public override int Attack(Human target)
        {
            if (target.Health<50)
            {
                int dmg=target.Health;
                target.Health-=dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge!");
                Console.WriteLine(target.Name+" is dead" );
                
            }
            else
            {
                base.Attack(target);
            }
            return target.Health;
        }
        public void Meditate()
        {
            Health=100;
            Console.WriteLine($"{Name} meditates and restores health to {Health}!");
        }
    }
}
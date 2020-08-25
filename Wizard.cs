using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Wizard : Human
    {
        public Wizard(string name):base(name)
        {
            base.Intelligence = 25;
            base.Health =50;
        }
        public override int Attack( Human target)
        {
            int dmg = Intelligence*5;
            int heal = dmg;
            target.Health -=dmg;
            this.Health +=heal;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damge!");
            Console.WriteLine($"{Name} is healed for {heal}!");
            return target.Health;
        }
        public int Heal( Human target)
        {
            int heal = 10*Intelligence;
            target.Health+=heal;
            Console.WriteLine($"{Name} heals {target.Name} for {heal} HP!");
            return target.Health;
        }
    }
}
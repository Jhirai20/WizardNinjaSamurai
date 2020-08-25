using System;
using System.Collections.Generic;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Wizard Sam= new Wizard("Sam");
            Ninja James=new Ninja("James");
            Samurai Jeff=new Samurai("Jeff");
            Sam.Attack(James);
            James.Attack(Jeff);
            Jeff.Attack(Sam);
            Sam.Heal(James);
            James.Steal(Jeff);
            Jeff.Meditate();
        }
    }
}

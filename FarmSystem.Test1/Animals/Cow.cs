using FarmSystem.Test1.Abstract_classes;
using FarmSystem.Test2;
using System;

namespace FarmSystem.Test1
{
    public class Cow : Animal, IMilkableAnimal
    {
        public Cow()
            : base("Moo")
        {
        }
        public void Walk()
        {
            Console.WriteLine("Cow is walking");
        }

        public void ProduceMilk()
        {
            Console.WriteLine("Cow was milked!");
        }

    }
}
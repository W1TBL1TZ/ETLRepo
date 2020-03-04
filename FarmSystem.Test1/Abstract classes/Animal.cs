using System;

namespace FarmSystem.Test1.Abstract_classes
{
    public abstract class Animal
    {
        private string _id;
        private int _noOfLegs;
        private string _noise;

        public Animal(string noise)
        {
            _noise = noise;
        }
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }


        public int NoOfLegs
        {
            get
            {
                return _noOfLegs;
            }
            set
            {
                _noOfLegs = value;
            }
        }

        public void Talk() => Console.WriteLine($"{this} says {_noise}!");

        public void Run()
        {
            Console.WriteLine($"{this} is running");
        }

        public override string ToString() => GetType().Name;
    }
}

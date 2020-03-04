using FarmSystem.Test1.Abstract_classes;
using FarmSystem.Test2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmSystem.Test1
{
    public class EmydexFarmSystem
    {
        private Queue<Animal> animals = new Queue<Animal>();
        public delegate void AnimalsReleased();
        public event AnimalsReleased FarmEmpty;
        //TEST 1
        public void Enter(Animal animal)
        {
            animals.Enqueue(animal);
            Console.WriteLine($"{animal} has entered the farm");
        }

        //TEST 2
        public void MakeNoise()
        {
            foreach (var animal in animals)
            {
                animal.Talk();
            }
        }

        //TEST 3
        public void MilkAnimals()
        {
            foreach (IMilkableAnimal animal in animals.Where(a => a as IMilkableAnimal != null))
            {
                animal.ProduceMilk();
            }
        }

        //TEST 4
        public void ReleaseAllAnimals()
        {
            while (animals.Count > 0)
            {
                Console.WriteLine($"{animals.Dequeue()} has left the farm");
            }
            FarmEmpty();
        }
    }
}
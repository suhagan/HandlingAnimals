using System;
namespace HandlingAnimals
{
    class GiraffeAnimal : AnimalClass
    {
        // New property specific to giraffes
        public double NeckLength { get; set; }

        // Constructor for creating giraffes
        public GiraffeAnimal(string name, string diet, string habitat, int age, double weight, double necklength)
            : base(name, diet, habitat, age, weight)
        {
            NeckLength = necklength;
        }

        // New method specific to giraffes
        public void SpreadLegs()
        {
            Console.WriteLine("The " + Name + " spreads legs to lower its neck to drink water.");
        }

        public override void Drink()
        {
            SpreadLegs();
        }
    }

}


using System;
using System.Xml.Linq;

namespace HandlingAnimals
{
    public class Bulldog : DogAnimal
    {
        public bool HasUnderbite { get; set; } // Whether the bulldog has an
                                               // "Underbite". Well! An underbite
                                               // is a dental condition where
                                               // lower front teeth protrude
                                               // or stick out beyond upper
                                               // front teeth. It can happen if
                                               // lower jaw extends beyond upper
                                               // jaw.

        public Bulldog(string name, string diet, string habitat, int age, double weight, string breed, bool hasunderbite)
            : base(name, diet, habitat, age, weight, breed)
        {
            HasUnderbite = hasunderbite;
        }

        // Method for drooling
        public void drool()
        {
            Console.WriteLine("Slurp! Slurp!!");
            Console.WriteLine("The " + Name + " is drooling.");
        } 

    }
}


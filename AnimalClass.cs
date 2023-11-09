using System;
using System.Xml.Linq;

namespace HandlingAnimals
{
    //Creating Animal class
    public class AnimalClass
    {
        //Creating common properties of Animal
        public string Name { get; set; } 
        public string Diet { get; set; } 
        public string Habitat { get; set; } 
        public int Age { get; set; } 
        public double Weight { get; set; } 

        //Constructor for Animal class
        public AnimalClass(string name, string diet, string habitat, int age, double weight)
        {
            Name = name;
            Diet = diet;
            Habitat = habitat;
            Age = age;
            Weight = weight;
        }

        // Methods that all animals share
        public virtual void MakeSound()
        {
            Console.WriteLine("The " + Name + " is making sound.");
        }

        public virtual void Eat()
        {
           Console.WriteLine("The " + Name + " is eating.");
        }

        public virtual void Drink()
        {
            Console.WriteLine("The " + Name + " is drinking.");
        }

        public virtual void Sleep()
        {
           Console.WriteLine("The " + Name + " is sleeping.");
        }
    }

}

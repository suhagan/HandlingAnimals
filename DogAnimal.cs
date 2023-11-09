using System;
using System.Xml.Linq;

namespace HandlingAnimals
{
    public class DogAnimal : AnimalClass
    {
        public string Breed { get; set; } // Own properties of dog: Breed of the dog

        public DogAnimal(string name, string diet, string habitat, int age, double weight, string breed)
            : base(name, diet, habitat, age, weight)
        {
            Breed = breed;
        }

        // Method for barking
        public void Bark()
        {
            Console.WriteLine("Woof!Woof!!");
            Console.WriteLine("The " + Name + " is making sound.");
        }

        // Override MakeSound() to bark
        public override void MakeSound()
        {
            Bark();
        }
    }
}


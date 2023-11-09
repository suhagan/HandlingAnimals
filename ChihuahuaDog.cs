using System;
using System.Xml.Linq;

namespace HandlingAnimals
{
    public class Chihuahua : DogAnimal
    {
        public bool IsLonghaired { get; set; } // Whether the chihuahua is
                                               // longhaired. They can be
                                               // longhaired.

        public Chihuahua(string name, string diet, string habitat, int age, double weight, string breed, bool islonghaired)
            : base(name, diet, habitat, age, weight, breed)
        {
            IsLonghaired= islonghaired;
        }

        // Own method for making own sound: yapping
        public void Yap()
        {
            Console.WriteLine("Yap, yap! Yip, yip!!");
            Console.WriteLine("The " + Name + " is making sound.");
        }

        // Override makeSound() to Yap
        public override void MakeSound()
        {
            Yap();
        } 
    }

}


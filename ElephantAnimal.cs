using System;
namespace HandlingAnimals
{
	public class ElephantAnimal: AnimalClass
	{
        // New property specific to elephants
        public int TuskLength { get; set; }

        public ElephantAnimal(string name, string diet, string habitat, int age, double weight, int tusklength)
            : base(name, diet, habitat, age, weight)
		{
            TuskLength = tusklength;
        }

        // New method specific to elephants
        public void Trumpet()
        {
            Console.WriteLine("bahruuuuuuhhhhaaaaa!!!");
            Console.WriteLine("The " + Name + " is trumpetting.");
        }

        // Override MakeSound() to Trumpet
        public override void MakeSound()
        {
            Trumpet();
        }
    }
}

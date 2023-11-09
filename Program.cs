using System;

namespace HandlingAnimals;

class Program
{
    public static void Main(string[] args)
    {
        AnimalClass dog = new DogAnimal("dog", "meat", "domestic", 5, 25, "mixed");
        AnimalClass bulldog = new Bulldog("bulldog", "meat", "domestic", 4, 30, "american", true);
        AnimalClass chihuahua = new Chihuahua("chihuahua", "dog food", "domestic", 3, 7, "british", false);
        AnimalClass elephant = new ElephantAnimal("elephant", "green plants", "not wild", 17, 170, 20);
        AnimalClass giraffe = new GiraffeAnimal("giraffe", "green leaves", "not wild", 10, 100, 400);

        dog.MakeSound();
        bulldog.MakeSound();
        chihuahua.MakeSound();
        elephant.MakeSound();
        giraffe.MakeSound();
        giraffe.Drink();

        Console.ReadLine();
    }
}
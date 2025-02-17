using System;
using System.Collections.Generic;

public class TestingZoo
{
    public static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>
        {
            new Dog("Joe", "Mammal"),
            new Cat("Good Kitten", "Mammal"),
            new Mouse("Squeek", "Mammal"),
            new Shark("Fin", "Fish"),
            new Salmon("Fishy", "Fish"),
            new Jellyfish("Squidward", "Fish")

        };

        // Simulate interaction with random selection
        Random rand = new Random();
        var prey = animals[rand.Next(animals.Count)];
        var predator = animals[rand.Next(animals.Count)];

        Console.WriteLine($"Predator: {predator.GetType().Name}, Prey: {prey.GetType().Name}");

        // If predator is an IPredator and prey is IPrey, the predator eats the prey
        if (predator is IPredator && prey is IPrey)
        {
            Console.WriteLine($"{predator.GetType().Name} hunts {prey.GetType().Name}.");
            animals.Remove(prey);  // Remove the prey from the list
        }
        else
        {
            Console.WriteLine($"{predator.GetType().Name} does not eat {prey.GetType().Name}.");
        }

        // Display remaining animals
        Console.WriteLine("\nRemaining animals:");
        foreach (var animal in animals)
        {
            Console.WriteLine(animal.GetType().Name);
        }





    }
}
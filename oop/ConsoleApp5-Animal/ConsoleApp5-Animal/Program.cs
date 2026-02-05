using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalClassProgram
{
    // Base class
    public class Animal
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        public Animal(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        // Virtual method for polymorphism
        public virtual decimal HowMuch()
        {
            return Cost;
        }
    }

    // Species (Little class)
    public class Species : Animal
    {
        public string Breed { get; set; }

        public Species(string name, string breed, decimal cost)
            : base(name, cost)
        {
            Breed = breed;
        }
    }

    // Dog class (Extra Cost For Walk)
    public class Dog : Species
    {
        public decimal WalkCost { get; set; }

        public Dog(string name, string breed, decimal cost, decimal walkCost)
            : base(name, breed, cost)
        {
            WalkCost = walkCost;
        }

        // Override HowMuch method for polymorphism
        public override decimal HowMuch()
        {
            return Cost + WalkCost;
        }
    }

    // Cat class 
    public class Cat : Species
    {
        public Cat(string name, string breed, decimal cost)
            : base(name, breed, cost)
        {
        }

        // Override HowMuch method for polymorphism
        public override decimal HowMuch()
        {
            return Cost * 1.1m; // Cats have 10% VAT
        }
    }

    // Elephant class 
    public class Elephant : Species
    {
        public Elephant(string name, string breed, decimal cost)
            : base(name, breed, cost)
        {
        }

        // Override HowMuch method for polymorphism
        public override decimal HowMuch()
        {
            return Cost * 1.5m; // Elephants have special handling cost
        }
    }

    // Lion class 
    public class Lion : Species
    {
        public Lion(string name, string breed, decimal cost)
            : base(name, breed, cost)
        {
        }

        // Override HowMuch method for polymorphism
        public override decimal HowMuch()
        {
            return Cost * 2.0m; // Lions are dangerous, double the cost
        }
    }

    class Program
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>
            {
                new Dog("Patrick", "German Shepherd", 200, 30),
                new Dog("Max", "Labrador", 180, 20),
                new Dog("Buddy", "Kangal", 160, 25),
                new Cat("Luna", "Van Cat", 150),
                new Cat("Milo", "British Shorthair", 140),
                new Cat("Nala", "Siamese", 130),
                new Elephant("Dumbo", "African", 1000),
                new Lion("Simba", "African", 800)
            };

            // POLYMORPHISM EXAMPLE 1: Same method, different behavior
            Console.WriteLine("=== POLYMORPHISM DEMONSTRATION ===");
            foreach (var animal in animals)
            {
                // Each animal type calculates its cost differently
                Console.WriteLine($"{animal.GetType().Name}: {animal.Name} - Total Cost: {animal.HowMuch()}");
            }
            Console.WriteLine();

            // POLYMORPHISM EXAMPLE 2: Calculating averages using polymorphism
            decimal averageDogCost = animals
                .OfType<Dog>()
                .Average(d => d.HowMuch());

            decimal averageCatCost = animals
                .OfType<Cat>()
                .Average(c => c.HowMuch());

            // POLYMORPHISM EXAMPLE 3: Calculating total using base class method
            decimal totalCostOfAllAnimals = animals.Sum(a => a.HowMuch());

            // POLYMORPHISM EXAMPLE 4: Grouping by type
            Console.WriteLine("=== DETAILED ANIMAL REPORT ===");
            var animalGroups = animals.GroupBy(a => a.GetType().Name);

            foreach (var group in animalGroups)
            {
                Console.WriteLine($"\n{group.Key}s:");
                foreach (var animal in group)
                {
                    Console.WriteLine($"  Name: {animal.Name}, Breed: {(animal as Species)?.Breed}, Base Cost: {animal.Cost}, Total: {animal.HowMuch()}");
                }
                Console.WriteLine($"  Average Cost for {group.Key}: {group.Average(a => a.HowMuch()):F2}");
            }

            // POLYMORPHISM EXAMPLE 5: Finding expensive animals
            Console.WriteLine("\n=== EXPENSIVE ANIMALS (Cost > 300) ===");
            var expensiveAnimals = animals.Where(a => a.HowMuch() > 300);
            foreach (var animal in expensiveAnimals)
            {
                Console.WriteLine($"{animal.GetType().Name}: {animal.Name} - ${animal.HowMuch()}");
            }

            Console.WriteLine("\n=== SUMMARY ===");
            Console.WriteLine($"Average Dog Cost: {averageDogCost:F2}");
            Console.WriteLine($"Average Cat Cost: {averageCatCost:F2}");
            Console.WriteLine($"Total Cost of All Animals: {totalCostOfAllAnimals:F2}");

            // POLYMORPHISM EXAMPLE 6: Using base class reference
            Console.WriteLine("\n=== ANIMAL COST COMPARISON ===");
            Animal cheapest = animals.OrderBy(a => a.HowMuch()).First();
            Animal mostExpensive = animals.OrderByDescending(a => a.HowMuch()).First();

            Console.WriteLine($"Cheapest: {cheapest.GetType().Name} {cheapest.Name} - ${cheapest.HowMuch()}");
            Console.WriteLine($"Most Expensive: {mostExpensive.GetType().Name} {mostExpensive.Name} - ${mostExpensive.HowMuch()}");
        }
    }
}
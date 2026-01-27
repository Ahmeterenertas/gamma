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

        public decimal TotalCost()
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

        public decimal TotalCost()
        {
            return Cost;
        }
    }

    // Elephant class 
    public class Elephant : Species
    {
        public Elephant(string name, string breed, decimal cost)
            : base(name, breed, cost)
        {
        }

        public decimal TotalCost()
        {
            return Cost;
        }
    }

    // Lion class 
    public class Lion : Species
    {
        public Lion(string name, string breed, decimal cost)
            : base(name, breed, cost)
        {
        }

        public decimal TotalCost()
        {
            return Cost;
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
            };

            decimal averageDogTotalCost = animals
                .OfType<Dog>()
                .Average(d => d.TotalCost());

            decimal averageCatTotalCost = animals
                .OfType<Cat>()
                .Average(c => c.TotalCost());

            decimal averageDogWalkCost = animals
                .OfType<Dog>()
                .Average(d => d.WalkCost);

            decimal totalCostOfAllAnimals = animals.Sum(a =>
            {
                if (a is Dog d) return d.TotalCost();
                if (a is Cat c) return c.TotalCost();
                return a.HowMuch();
            });

            Console.WriteLine("Dogs:");
            foreach (var dog in animals.OfType<Dog>())
            {
                Console.WriteLine(
                    $"Name: {dog.Name}, Breed: {dog.Breed}, Base Cost: {dog.Cost}, Walk Cost: {dog.WalkCost}, Total Cost: {dog.TotalCost()}"
                );
            }

            Console.WriteLine();
            Console.WriteLine("Cats:");
            foreach (var cat in animals.OfType<Cat>())
            {
                Console.WriteLine(
                    $"Name: {cat.Name}, Breed: {cat.Breed}, Cost: {cat.Cost}"
                );
            }

            Console.WriteLine();
            Console.WriteLine($"Average Dog Total Cost: {averageDogTotalCost}");
            Console.WriteLine($"Average Dog Walk Cost: {averageDogWalkCost}");
            Console.WriteLine($"Average Cat Total Cost: {averageCatTotalCost}");
            Console.WriteLine($"Total Cost of All Animals: {totalCostOfAllAnimals}");
        }
    }
}

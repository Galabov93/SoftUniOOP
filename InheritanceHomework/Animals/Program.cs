using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            animals.Add(new Cat("maca", 10));
            animals.Add(new Dog("Sharo", 7));
            animals.Add(new Dog("Lasi", 20));
            animals.Add(new Frog("Franklin", 6));
            animals.Add(new Kitten("Macapisa", 10));
            animals.Add(new Frog("jabok", 10));
            animals.Add(new Dog("Bruno", 10));

            foreach (var item in animals
                .GroupBy(animal => animal.GetType().Name)
                .Select(group => new
                {
                    AnimalName = group.Key,
                    AverageAge = group.Average(a => a.Age)
                }).OrderByDescending(group => group.AverageAge))
            {
                Console.WriteLine(item);
            }
        }
    }
}

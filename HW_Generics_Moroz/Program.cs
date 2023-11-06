using Animals;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW_Generics_Moroz
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat()
            {
                Name = "Cat class",
                Description = "Cat => Meow",
                Population = 12
            };
            Animal cat2 = new Cat()
            {
                Name = "Animal class",
                Description = "Animal => Meow",
                Population = 21
            };   

            Console.WriteLine(cat1.GetPopulation());
            Console.WriteLine(cat1.GetDescription());
            Console.WriteLine($"Sounds: {cat1.Sounds}");
            Console.WriteLine(cat1.GetCuteInfo());
            Console.WriteLine("\n");
            Console.WriteLine(cat2.GetPopulation());
            Console.WriteLine(cat2.GetDescription());
            Console.WriteLine($"Sounds: {cat2.Sounds}");
            Console.WriteLine(cat2.GetCuteInfo());
            Console.WriteLine("\n");
            AnimalManager<Animal> Kitty = new AnimalManager<Animal>();
            Console.WriteLine(Kitty.GetFullAnimalInfo(cat1));
            Kitty.AddSomeInfo<string>(cat1, "Cat");
            Console.WriteLine(Kitty.GetFullAnimalInfo(cat2));
            Kitty.AddSomeInfo<string>(cat2, "Animal");
            Console.ReadKey();

            /*
            Console 1 Task

            Current population of Cat class: 12 cute cats    *GetPopulation from Cat class
            Name: Cat class, Description: Cat => Meow + 1    *GetDescription from Cat class


            Current population of Animal class: 21 cute cats *GetPopulation from Cat class
            Description for :                                *GetDescription from Animal class
            
            Empty cause don't have info in property which in abstract class
             */
        }
    }
}

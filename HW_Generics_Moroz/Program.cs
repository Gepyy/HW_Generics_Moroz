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
            Console.WriteLine("\n");
            Console.WriteLine(cat2.GetPopulation());
            Console.WriteLine(cat2.GetDescription());
            Console.ReadKey();

            /*
             Current population of Cat class: 10 cute cats    *GetPopulation from Cat class
             Description for Cat class: Cat => Meow + 1       *GetDescription from Cat class

             Current population of Animal class: 10 cute cats *GetPopulation from Cat class
             Description for Animal class: Animal => Meow     *GetDescription from Animal class
             */
        }
    }
}

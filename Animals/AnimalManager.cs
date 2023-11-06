using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class AnimalManager<T> where T : Animal
    {
        public List<T> list = new List<T>();
        public string GetFullAnimalInfo(T obj)
        {
            return obj.GetPopulation() + obj.GetDescription() + obj.Sounds;
        }
        public void AddSomeInfo<T2>(T obj, T2 data)
        {
            list.Add(obj);
            Console.WriteLine(data);
        }
    }
}

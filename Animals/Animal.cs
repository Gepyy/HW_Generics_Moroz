using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Population { get; set; }
        public abstract string Sounds { get;}
        public virtual string GetPopulation() => $"Current population of {Name}: {Population}";
        public string GetDescription() => $"Description for {Name}: {Description}";
        public abstract string GetCuteInfo();
    }
}

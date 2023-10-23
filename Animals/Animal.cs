using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract int Population { get; set; }
        public virtual string GetPopulation() => $"Current population of {Name}: {Population}";
        public string GetDescription() => $"Description for {Name}: {Description}";
    }
}

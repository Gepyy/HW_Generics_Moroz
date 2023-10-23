using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat : Animal
    {
        private string _name;
        private string _description;
        private int _population;
        public override string Name
        {
            get => _name; 
            set => _name = value;
        }
        public override string Description
        {
            get => _description;
            set => _description = value;
        }
        public override int Population
        {
            get => _population;
            set => _population = value;
        }
        public override string GetPopulation() => $"Current population of {Name}: 10 cute cats";
        public new string GetDescription() => $"{base.GetDescription()} + 1";
    }
}

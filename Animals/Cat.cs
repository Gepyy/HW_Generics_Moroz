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
        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public string Description
        {
            get => _description;
            set => _description = value;
        }
        public int Population
        {
            get => _population;
            set => _population = value;
        }
        public override string Sounds
        { 
            get => "Meow meow"; 
        }
        public override string GetPopulation() => $"Current population of {Name}: {Population} cute cats";
        public new string GetDescription() => $"Name: {Name}, Description: {Description} + 1";

        public override string GetCuteInfo() => $"Name:3 {Name} :3, Description:3 {Description} :3, Population:3 {Population} :3, Sounds:3 {Sounds}:3";
    }
}

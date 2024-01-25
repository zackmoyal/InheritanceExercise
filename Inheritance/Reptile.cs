using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        //members that are specific to Reptile
        public bool HasScales { get; set; }
        public bool IsColdBlooded { get; set; }
        public string Environment {  get; set; }
        public int PreferredTemperature { get; set; }

        //constructor for Bird class
        public Reptile(string species, int age, bool hasTail, string name, bool hasScales, bool isColdBlooded, string environment, int preferredTemperature)
            : base(species, age, hasTail, name)
        {
            HasScales = hasScales;
            IsColdBlooded = isColdBlooded;
            Environment = environment;
            PreferredTemperature = preferredTemperature;
        }
    }
}

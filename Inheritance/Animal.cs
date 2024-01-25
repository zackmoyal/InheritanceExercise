using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        //members that are specific to animals
        public string Species { get; set; }
        public int Age { get; set; }
        public bool HasTail { get; set; }
        public string Name { get; set; }

        //constructor for Animal class
        public Animal(string species, int age, bool hasTail, string name)
        {
            Species = species;
            Age = age;
            HasTail = hasTail;
            Name = name;
        }
    }
}

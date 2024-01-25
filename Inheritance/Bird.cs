using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        //members that are specific to birds
        public bool CanFly { get; set; }
        public int WingSpan { get; set; }
        public string FeatherColor { get; set; }
        public bool IsBeakSharp { get; set; }

        //constructor for Bird class
        public Bird(string species, int age, bool hasTail, string name, bool canFly, int wingSpan, string featherColor, bool isBeakSharp)
            : base(species, age, hasTail, name)
        {
            CanFly = canFly;
            WingSpan = wingSpan;
            FeatherColor = featherColor;
            IsBeakSharp = isBeakSharp;
        }
    }
}

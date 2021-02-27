using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalGuessing_Game
{
    class Animal
    {
        public string name { get; set; }
        public string location { get; set; }
        public string covering { get; set; }

        public Animal(string aName, string aLocation, string aCovering)
        {
            name = aName;
            location = aLocation;
            covering = aCovering;
        }
    }
}

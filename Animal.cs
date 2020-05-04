using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public Animal(string name, int points, bool meat)
        {
            AnimalName = name;
            AnimalPoints = points;
            MeatEater = meat;
        }

        public string AnimalName { get; }
        public int AnimalPoints { get; }
        public bool MeatEater { get; }
    }
}

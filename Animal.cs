using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Animal
    {
        public Animal(string name, int points, Eater eater)
        {
            AnimalName = name;
            AnimalPoints = points;
            Eater = eater;
        }

        public string AnimalName { get; }
        public int AnimalPoints { get; }
        public Eater Eater { get; }

        //Tostring
    }
}

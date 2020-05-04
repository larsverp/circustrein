using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Container
    {
        private List<Animal> animals = new List<Animal>();
        private bool hasMeateater = false;
        private int sizeLeft = 10;

        public bool AddAnimal(Animal animal)
        {
            if(sizeLeft-animal.AnimalPoints >= 0)
            {
                if (animal.MeatEater == true)
                {
                    if(hasMeateater == false)
                    {
                        bool danger = false;
                        foreach (Animal checkAnimal in animals)
                        {
                            if (checkAnimal.MeatEater == false && checkAnimal.AnimalPoints <= animal.AnimalPoints)
                            {
                                danger = true;
                            }
                        }

                        if(danger == false)
                        {
                            animals.Add(animal);
                            sizeLeft = sizeLeft - animal.AnimalPoints;
                            hasMeateater = true;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    bool danger = false;
                    foreach (Animal checkAnimal in animals)
                    {
                        if(checkAnimal.MeatEater == true && checkAnimal.AnimalPoints >= animal.AnimalPoints)
                        {
                            danger = true;
                        }
                    }

                    if(danger == false)
                    {
                        animals.Add(animal);
                        sizeLeft = sizeLeft - animal.AnimalPoints;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }

        public List<Animal> allAnimals
        {
            get{ return animals; }
        }

        public int points
        {
            get { return 10-sizeLeft; }
        }
    }
}

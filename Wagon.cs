using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    public class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        private bool hasMeateater = false;
        private int sizeLeft = 10;

        public bool AddAnimal(Animal animal)
        {
            if(sizeLeft-animal.AnimalPoints >= 0)
            {
                if (animal.Eater == Eater.carnivor)
                {
                    if(hasMeateater == false)
                    {
                        //Place at top
                        bool danger = false;
                        foreach (Animal checkAnimal in animals)
                        {
                            if (checkAnimal.Eater != Eater.carnivor && checkAnimal.AnimalPoints <= animal.AnimalPoints)
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
                        if(checkAnimal.Eater == Eater.carnivor && checkAnimal.AnimalPoints >= animal.AnimalPoints)
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
            //Return a copy of the list (Read only)
            get{ return animals; }
        }

        public int points
        {
            //Make this more flexible
            get { return 10-sizeLeft; }
        }
    }
}

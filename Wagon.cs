using System.Collections.Generic;

namespace CircusTrein
{
    public class Wagon
    {
        private List<Animal> animals = new List<Animal>();
        private bool hasMeateater;
        private bool danger;
        private int sizeLeft = 10;
        public const int Size = 10;

        public bool AddAnimal(Animal animal)
        {
            if(sizeLeft-animal.AnimalPoints >= 0)
            {
                if (animal.Eater == Eater.carnivor)
                {
                    if(hasMeateater == false)
                    {
                        danger = false;
                        foreach (Animal checkAnimal in animals)
                        {
                            if (checkAnimal.Eater != Eater.carnivor && checkAnimal.AnimalPoints <= animal.AnimalPoints)
                                danger = true;
                        }

                        if(danger == false)
                        {
                            animals.Add(animal);
                            sizeLeft = sizeLeft - animal.AnimalPoints;
                            hasMeateater = true;
                            return true;
                        }
                    }
                    return false;
                }
                else
                {
                    danger = false;
                    foreach (Animal checkAnimal in animals)
                    {
                        if (checkAnimal.Eater == Eater.carnivor && checkAnimal.AnimalPoints >= animal.AnimalPoints)
                            danger = true;
                    }

                    if(danger == false)
                    {
                        animals.Add(animal);
                        sizeLeft = sizeLeft - animal.AnimalPoints;
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public List<Animal> AllAnimals
        {
            get{ return animals; }
        }

        public int Points
        {
            get { return Size-sizeLeft; }
        }
    }
}

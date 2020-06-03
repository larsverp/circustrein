using System.Collections.Generic;

namespace CircusTrein
{
    public class Train
    {
        public List<Wagon> wagons { get; } = new List<Wagon>();
        public Train(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Eater == Eater.carnivor)
                {
                    wagons.Add(new Wagon());
                    wagons[wagons.Count - 1].AddAnimal(animals[i]);
                    animals.Remove(animals[i]);
                }
            }

            while (animals.Count > 0)
            {
                for (int j = 0; j < wagons.Count; j++)
                {
                    var count = animals.Count;
                    for (int x = 0; x < count; x++)
                    {
                        if (wagons[j].AddAnimal(animals[0]))
                            animals.Remove(animals[0]);
                    }
                }
                if (animals.Count > 0)
                    wagons.Add(new Wagon());
            }
            if (wagons[wagons.Count - 1].Points <= 0)
                wagons.Remove(wagons[wagons.Count - 1]);
        }
    }
}

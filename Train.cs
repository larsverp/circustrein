using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrein
{
    class Train
    {
        public static List<Wagon> train = new List<Wagon>();
        public Train(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].Eater == Eater.carnivor)
                {
                    train.Add(new Wagon());
                    train[train.Count - 1].AddAnimal(animals[i]);
                    animals.Remove(animals[i]);
                }
            }

            while (animals.Count > 0)
            {

                for (int j = 0; j < train.Count; j++)
                {
                    for (int x = 0; x < animals.Count; x++)
                    {
                        if (train[j].AddAnimal(animals[x]))
                        {
                            animals.Remove(animals[x]);
                        }
                    }
                }
                if (animals.Count > 0)
                {
                    train.Add(new Wagon());
                }
            }
            if (train[train.Count - 1].points <= 0)
            {
                train.Remove(train[train.Count - 1]);
            }
            result form = new result();
            form.Show();
        }
    }
}

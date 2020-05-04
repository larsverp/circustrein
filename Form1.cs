using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        public static List<Container> train = new List<Container>();
        public Form1()
        {
            InitializeComponent();
        }

        public void newAnimal(Animal animal)
        {
            animals.Add(animal);
            animalList.Items.Add("Name: "+animal.AnimalName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string animalName = name.Text;
            bool eatsMeat = meat.Checked;
            int animalPoint;

            if(small.Checked == true)
            {
                animalPoint = 1;
            }
            else if(medium.Checked == true)
            {
                animalPoint = 3;
            }
            else
            {
                animalPoint = 5;
            }

            newAnimal(new Animal(animalName, animalPoint, eatsMeat));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                if (animals[i].MeatEater)
                {
                    train.Add(new Container());
                    train[train.Count - 1].AddAnimal(animals[i]);
                    animals.Remove(animals[i]);
                }
            }

            while (animals.Count > 0) {

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
                if(animals.Count > 0)
                {
                    train.Add(new Container());
                }
            }
            if(train[train.Count-1].points <= 0)
            {
                train.Remove(train[train.Count - 1]);
            }
            result form = new result();
            form.Show();

        }
    }
}

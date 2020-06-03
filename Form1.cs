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
        public Form1()
        {
            InitializeComponent();
        }

        public void NewAnimal(Animal animal)
        {
            animals.Add(animal);
            animalList.Items.Add(animal.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string animalName = name.Text;
            Eater eater;
            
            if (meat.Checked)
                eater = Eater.carnivor;
            else
                eater = Eater.herbivor;
            int animalPoint;

            if(small.Checked == true)
                animalPoint = 1;
            else if(medium.Checked == true)
                animalPoint = 3;
            else
                animalPoint = 5;

            NewAnimal(new Animal() {
                AnimalName = animalName,
                AnimalPoints = animalPoint,
                Eater = eater
            });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Train train = new Train(animals);
            var wagons = train.wagons;
            Result form = new Result(wagons);
            form.Show();
        }
    }
}

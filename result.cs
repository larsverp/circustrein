using System;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e) {
            totalC.Text = Train.train.Count.ToString();
            int i = 1;
            string eater;
            foreach(Wagon container in Train.train)
            {
                containerBox.Items.Add("Container "+i.ToString()+" ("+container.points.ToString()+" points total)");
                foreach (Animal animal in container.allAnimals)
                {
                    if (animal.Eater == Eater.carnivor)
                    {
                        eater = "Meat eater";
                    }
                    else
                    {
                        eater = "Plant eater";
                    }
                    containerBox.Items.Add("Name: " + animal.AnimalName + " | Type: " + eater + " | Points: " + animal.AnimalPoints.ToString());
                }
                containerBox.Items.Add("");
                i++;
            }
        }
    }
}

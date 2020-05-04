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
    public partial class result : Form
    {
        public result()
        {
            InitializeComponent();
        }

        private void result_Load(object sender, EventArgs e) {
            totalC.Text = Form1.train.Count.ToString();
            int i = 1;
            string eater;
            foreach(Container container in Form1.train)
            {
                containerBox.Items.Add("Container "+i.ToString()+" ("+container.points.ToString()+" points total)");
                foreach (Animal animal in container.allAnimals)
                {
                    if (animal.MeatEater)
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

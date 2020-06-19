using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CircusTrein
{
    public partial class FrmResult : Form
    {
        private List<Wagon> wagons = new List<Wagon>();
        public FrmResult(List<Wagon> wagons)
        {
            InitializeComponent();
            this.wagons = wagons;
        }

        private void result_Load(object sender, EventArgs e) {
            totalC.Text = wagons.Count.ToString();
            int i = 1;
            string eater;
            foreach(Wagon container in wagons)
            {
                containerBox.Items.Add("Container "+i.ToString()+" ("+container.Points.ToString()+" points total)");
                foreach (Animal animal in container.AllAnimals)
                {
                    if (animal.Eater == Eater.Carnivor)
                        eater = "Meat eater";
                    else
                        eater = "Plant eater";

                    containerBox.Items.Add(animal.ToString());
                }
                containerBox.Items.Add("");
                i++;
            }
        }
    }
}

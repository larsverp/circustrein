namespace CircusTrein
{
    public class Animal
    {
        public string AnimalName { get; set; }
        public int AnimalPoints { get; set; }
        public Eater Eater { get; set; }

        public override string ToString()
        {
            return "Name: " + AnimalName + " | Type: " + Eater + " | Points: " + AnimalPoints.ToString();
        }
    }
}

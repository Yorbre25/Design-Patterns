namespace VehicleNamespace
{
    public class Car
    {
        public bool hasFuel;
        public string Color;
        public bool IsBroken;
        public Car()
        {
            hasFuel = false;
            Color = "Red";
            IsBroken = false;
        }

        public void paint(string color)
        {
            Color = color;
        }

        public void repair()
        {
            IsBroken = false;
        }

        public void refuel()
        {
            hasFuel = true;
        }
    }
}

namespace VehicleNamespace
{
    class CarObjectMother
    {

        public static Car createCarWithFuel()
        {
            Car fulledCar = new Car();
            fulledCar.refuel();
            return fulledCar;
        }

        public static Car createWhiteCar()
        {
            Car whiteCar = new Car();
            whiteCar.paint("White");
            return whiteCar;
        }

        public static Car createBrokenCar()
        {
            Car brokenCar = new Car();
            brokenCar.IsBroken = true;
            return brokenCar;
        }
    }
}
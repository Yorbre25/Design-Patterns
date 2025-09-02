using VehicleNamespace;

class Program
{
    static void Main(string[] args)
    {
        testPaintingBrokenCar();
    }

    static void testPaintingBrokenCar()
    {
        var brokenCar = CarObjectMother.createBrokenCar();
        brokenCar.paint("Blue");
        Console.WriteLine($"Broken car painted: {brokenCar.Color}");
    }
}

// Example: Difference between creating objects directly and using the Factory Method pattern
using Factory.Creators;
using Factory.KitchenTools;

class Program
{
	static void Main(string[] args)
	{
	// Without Factory pattern
	KitchenTool fork1 = new Fork("Steel"); //If the creation changes, I need to change everything
	KitchenTool spoon1 = new Spoon("Plastic");
	Console.WriteLine($"Without Factory: {fork1.Use()} | {spoon1.Use()}");

	// With Factory pattern
	Creator forkCreator = new ForkCreator();
	Creator spoonCreator = new SpoonCreator();
	KitchenTool fork2 = forkCreator.FactoryMethod("Wood"); //If the constructor changes, I can change the ForkCreator implementation without modifying this code.
	KitchenTool spoon2 = spoonCreator.FactoryMethod("Ceramic");
	Console.WriteLine($"With Factory: {fork2.Use()} | {spoon2.Use()}");

	}
}

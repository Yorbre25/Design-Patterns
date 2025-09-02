namespace Factory
{
    // Concrete implementation of Creator to create Fork objects.
    public class ForkCreator : Creator
    {
    // Creates and returns a fork with the specified material.
        public KitchenTool FactoryMethod(string material)
        {
            return new Fork(material);
        }
    }
}

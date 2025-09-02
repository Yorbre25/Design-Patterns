using Factory.KitchenTools;

namespace Factory.Creators
{
    // Concrete implementation of Creator to create Fork objects.
    public class ForkCreator : Creator
    {
    // Creates and returns a fork with the specified material.
        public override KitchenTool FactoryMethod(string material)
        {
            return new Fork(material);
        }
    }
}

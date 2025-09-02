using Factory.KitchenTools;

namespace Factory.Creators
{
    // Concrete implementation of Creator to create Spoon objects.
    public class SpoonCreator : Creator
    {
    // Creates and returns a spoon with the specified material.
        public override KitchenTool FactoryMethod(string material)
        {
            return new Spoon(material);
        }
    }
}

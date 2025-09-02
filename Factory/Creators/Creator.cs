using Factory.KitchenTools;

namespace Factory.Creators
{
    public abstract class Creator
    {
    // Factory method to be implemented by subclasses to create kitchen tools.
        public abstract KitchenTool FactoryMethod(string material);
    }
}
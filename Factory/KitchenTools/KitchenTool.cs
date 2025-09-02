namespace Factory.KitchenTools
{
    // Abstract base class for all kitchen tools.
    public abstract class KitchenTool
    {
        public string Name { get; set; }
        public string Material { get; set; }

        public KitchenTool(string name, string material)
        {
            Name = name;
            Material = material;
        }

        // Simulates using the kitchen tool.
        public string Use()
        {
            return $"Using the {Name} made of {Material}.";
        }
    }
}
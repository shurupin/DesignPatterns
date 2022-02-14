namespace Composite
{
    public class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, double price, bool isveg)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Vegetarian = isveg;
        }

        public override string Name { get; }

        public override string Description { get; }

        public override double Price { get; }

        public override bool Vegetarian { get; }

        public override void Print()
        {
            Console.WriteLine(value: $"{this.Name}: {this.Price}$, {(this.Vegetarian ? "vegetarian" : "not vegetarian")}, {this.Description}");
        }
    }
}
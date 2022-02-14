namespace Composite
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> _components = new List<MenuComponent>();

        public Menu(string name, string description)
        {
            this.Name = name;
            this.Description = description;

        }

        public override void Add(MenuComponent component)
        {
            this._components.Add(item: component);
        }

        public override void Remove(MenuComponent component)
        {
            this._components.Remove(item: component);
        }

        public override MenuComponent GetChild(int i)
        {
            return this._components[index: i];
        }

        public override string Name { get; }

        public override string Description { get; }

        public override void Print()
        {
            Console.WriteLine(value: this.Name.ToUpper());
            Console.WriteLine(value: "----------");
            foreach (MenuComponent menuComponent in this._components)
            {
                menuComponent.Print();
            }
            Console.WriteLine();
        }
    }
}
namespace Composite
{
    public class Client
    {
        private readonly MenuComponent _menus;

        public Client(MenuComponent menus)
        {
            this._menus = menus;
        }

        public void Print()
        {
            this._menus.Print();
        }
    }
}
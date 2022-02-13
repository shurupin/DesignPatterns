namespace Builder
{
    // The builder class specifies methods for creating (manipulating) the different parts of the object
    public class HamburgerBuilder
    {
        private bool _hasBread;
        private bool _hasMeal;
        private bool _hasCheese;
        private bool _hasTomato;
        private bool _hasSalad;
        private bool _hasMayonnaise;

        public HamburgerBuilder AddBread()
        {
            this._hasBread = true;
            return this;
        }

        public HamburgerBuilder AddMeal()
        {
            this._hasMeal = true;
            return this;
        }

        public HamburgerBuilder AddCheese()
        {
            this._hasCheese = true;
            return this;
        }

        public HamburgerBuilder AddTomato()
        {
            this._hasTomato = true;
            return this;
        }

        public HamburgerBuilder AddSalad()
        {
            this._hasSalad = true;
            return this;
        }

        public HamburgerBuilder AddMayonnaise()
        {
            this._hasMayonnaise = true;
            return this;
        }

        public Hamburger Build() => new Hamburger(hasBread: this._hasBread, hasMeal: this._hasMeal, hasCheese: this._hasCheese, hasTomato: this._hasTomato, hasSalad: this._hasSalad, hasMayonnaise: this._hasMayonnaise);
    }
}

namespace Builder
{
    public class Hamburger
    {
        public bool HasBread { get; }
        public bool HasMeal { get; }
        public bool HasCheese { get; }
        public bool HasTomato { get; }
        public bool HasSalad { get; }
        public bool HasMayonnaise { get; }

        internal Hamburger(bool hasBread, bool hasMeal, bool hasCheese, bool hasTomato, bool hasSalad, bool hasMayonnaise)
        {
            this.HasBread = hasBread;
            this.HasMeal = hasMeal;
            this.HasCheese = hasCheese;
            this.HasTomato = hasTomato;
            this.HasSalad = hasSalad;
            this.HasMayonnaise = hasMayonnaise;
        }

        public override string ToString()
        {
            return (this.HasBread ? "Bread " : string.Empty)
                + (this.HasMeal ? "Meal " : string.Empty)
                + (this.HasCheese ? "Cheese " : string.Empty)
                + (this.HasTomato ? "Tomato " : string.Empty)
                + (this.HasSalad ? "Salad " : string.Empty)
                + (this.HasMayonnaise ? "Mayonnaise " : string.Empty);
        }
    }
}
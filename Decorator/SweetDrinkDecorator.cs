namespace Decorator
{
    class SweetDrinkDecorator : DrinkDecorator
    {
        Drink _drink;

        public SweetDrinkDecorator(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                if (this._drink.Description.Contains(value: "Sweet"))
                {
                    return this._drink.Description.Replace(oldValue: "Sweet", newValue: "Super Sweet");
                }

                return "Sweet " + this._drink.Description;
            }
        }

        public override decimal Cost()
        {
            return 0.2M + this._drink.Cost();
        }
    }
}

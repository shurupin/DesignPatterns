namespace Decorator
{
    class HotDrinkDecorator : DrinkDecorator
    {
        Drink _drink;

        public HotDrinkDecorator(Drink drink)
        {
            this._drink = drink;
        }

        public override string Description
        {
            get
            {
                if (this._drink.Description.Contains(value: "Hot"))
                {
                    return this._drink.Description.Replace("Hot", "Maximum Hot");
                }

                return "Hot " + this._drink.Description;
            }
        }

        public override decimal Cost()
        {
            return 0.3M + this._drink.Cost();
        }
    }
}

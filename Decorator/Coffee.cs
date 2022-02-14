namespace Decorator
{
    internal class Coffee : Drink
    {
        public Coffee()
        {
            this._description = "Coffee";
        }

        public override string Description => this._description;

        public override decimal Cost()
        {
            return 1.5M;
        }
    }
}
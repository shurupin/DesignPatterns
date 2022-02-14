namespace Decorator
{
    abstract class DrinkDecorator : Drink
    {
        public abstract override string Description { get; }
    }
}

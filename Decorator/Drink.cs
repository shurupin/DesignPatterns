namespace Decorator
{
    abstract class Drink
    {
        protected string _description = "No Description";
        public abstract string Description { get; }
        public abstract decimal Cost();
    }
}

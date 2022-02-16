namespace TemplateMethod
{
    public abstract class Bread
    {
        /// <summary> The template method </summary>
        public void Make()
        {
            this.MixIngredients();
            this.Bake();
            this.Slice();
        }

        protected abstract void MixIngredients();

        protected abstract void Bake();

        protected virtual void Slice()
        {
            Console.WriteLine(value: $"Slicing the {this.GetType().Name}!");
        }
    }
}

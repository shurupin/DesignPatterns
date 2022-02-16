namespace TemplateMethod
{
    public class WhiteBread : Bread
    {
        protected override void MixIngredients()
        {
            Console.WriteLine(value: "Gathering ingredients for white bread.");
        }

        protected override void Bake()
        {
            Console.WriteLine(value: "Baking the white bread for 15 minutes.");
        }
    }
}

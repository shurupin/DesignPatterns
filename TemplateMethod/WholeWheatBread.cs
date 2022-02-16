namespace TemplateMethod
{
    public class WholeWheatBread : Bread
    {
        protected override void MixIngredients()
        {
            Console.WriteLine(value: "Gathering ingredients for whole wheat bread.");
        }

        protected override void Bake()
        {
            Console.WriteLine(value: "Baking the whole wheat bread for 20 minutes.");
        }
    }
}

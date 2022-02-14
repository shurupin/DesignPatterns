namespace Decorator
{
    static class Program
    {
        static void Main()
        {
            Coffee coffee = new Coffee();
            SweetDrinkDecorator sweetCoffee = new SweetDrinkDecorator(drink: coffee);
            SweetDrinkDecorator superSweetCoffee = new SweetDrinkDecorator(drink: sweetCoffee);
            HotDrinkDecorator hotSuperSweetCoffee = new HotDrinkDecorator(drink: superSweetCoffee);
            Console.WriteLine(value: hotSuperSweetCoffee.Description + " $" + hotSuperSweetCoffee.Cost());

            //Drink latte = new Coffee();
            //latte = new SweetDrinkDecorator(drink: latte);
            //latte = new SweetDrinkDecorator(drink: latte);
            //latte = new HotDrinkDecorator(drink: latte);
            //Console.WriteLine(value: latte.Description + " $" + latte.Cost());
        }
    }
}
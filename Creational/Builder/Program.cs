namespace Builder
{
    using System;

    class Program
    {
        static void Main()
        {
            Hamburger myHamburger = new HamburgerBuilder()
                .AddBread()
                .AddMeal()
                .AddCheese()
                .AddTomato()
                .AddSalad()
                .AddMayonnaise()
                .Build();
            Console.WriteLine(value: $"My hamburger: {myHamburger}");

            Hamburger myWifeHamburger = new HamburgerBuilder()
                .AddBread()
                .AddSalad()
                .Build();
            Console.WriteLine(value: $"My wife's hamburger: {myWifeHamburger}");
        }
    }
}

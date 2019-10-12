using System;

namespace Builder
{
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
            Console.WriteLine($"My hamburger: {myHamburger}");

            Hamburger myWifeHamburger = new HamburgerBuilder()
                .AddBread()
                .AddSalad()
                .Build();
            Console.WriteLine($"My wife's hamburger: {myWifeHamburger}");
        }
    }
}

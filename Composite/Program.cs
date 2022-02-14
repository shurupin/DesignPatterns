namespace Composite
{
    internal static class Program
    {
        private static void Main()
        {
            Menu breakfastMenu = new Menu(name: "Breakfast", description: "Pancake House");
            Menu lunchMenu = new Menu(name: "Lunch", description: "Deli Diner");
            Menu dinnerMenu = new Menu(name: "Dinner", description: "Dinneroni");
            Menu dessertMenu = new Menu(name: "Dessert", description: "Ice Cream");
            Menu allMenu = new Menu(name: "All", description: "McDonalds");

            breakfastMenu.Add(component: new MenuItem(name: "Waffles", description: "Butterscotch waffles", price: 140, isveg: false));
            breakfastMenu.Add(component: new MenuItem(name: "Corn Flakes", description: "Kellogs", price: 80, isveg: true));

            lunchMenu.Add(component: new MenuItem(name: "Burger", description: "Cheese and Onion Burger", price: 250, isveg: true));
            lunchMenu.Add(component: new MenuItem(name: "Sandwich", description: "Chicken Sandwich", price: 280, isveg: false));

            dinnerMenu.Add(component: new MenuItem(name: "Pizza", description: "Cheese and Tomato Pizza", price: 210, isveg: true));
            dinnerMenu.Add(component: new MenuItem(name: "Pasta", description: "Chicken Pasta", price: 280, isveg: false));

            dessertMenu.Add(component: new MenuItem(name: "Ice Cream", description: "Vanilla and Chocolate", price: 120, isveg: true));
            dessertMenu.Add(component: new MenuItem(name: "Cake", description: "Choclate Cake Slice", price: 180, isveg: false));

            dinnerMenu.Add(component: dessertMenu);

            allMenu.Add(component: breakfastMenu);
            allMenu.Add(component: lunchMenu);
            allMenu.Add(component: dinnerMenu);

            //allMenu.Print();

            Client client = new Client(menus: allMenu);
            client.Print();
        }
    }
}
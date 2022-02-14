namespace Flyweight
{
    static class Program
    {
        static void Main()
        {
            Car[] cars = {
                new() { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
                new() { Company = "Mercedes Benz", Model = "C300", Color = "black" },
                new() { Company = "Mercedes Benz", Model = "C500", Color = "red" },
                new() { Company = "BMW", Model = "M5", Color = "red" },
                new() { Company = "BMW", Model = "X6", Color = "white" }
            };
            FlyweightFactory factory = new(cars: cars);
            factory.ListFlyweights();

            Car car1 = new()
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "M5",
                Color = "red"
            };
            AddCarToPoliceDatabase(factory: factory, car: car1);

            Car car2 = new()
            {
                Number = "CL234IR",
                Owner = "James Doe",
                Company = "BMW",
                Model = "X1",
                Color = "red"
            };
            AddCarToPoliceDatabase(factory: factory, car: car2);

            factory.ListFlyweights();
        }

        public static void AddCarToPoliceDatabase(FlyweightFactory factory, Car car)
        {
            Console.WriteLine(value: "\nClient: Adding a car to database.");

            Flyweight flyweight = factory.GetFlyweight(sharedState: new()
            {
                Color = car.Color,
                Model = car.Model,
                Company = car.Company
            });

            flyweight.Operation(uniqueState: car);
        }
    }
}
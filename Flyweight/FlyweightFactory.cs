namespace Flyweight
{
    public class FlyweightFactory
    {
        private List<Tuple<Flyweight, string>> flyweights = new();

        public FlyweightFactory(params Car[] cars)
        {
            foreach (Car car in cars)
            {
                Flyweight flyweight = new(car: car);
                string key = this.GetKey(car: car);
                Tuple<Flyweight, string> tuple = new(item1: flyweight, item2: key);
                this.flyweights.Add(item: tuple);
            }
        }

        public string GetKey(Car car)
        {
            List<string> elements = new();

            elements.Add(item: car.Model);
            elements.Add(item: car.Color);
            elements.Add(item: car.Company);

            if (car.Owner != null && car.Number != null)
            {
                elements.Add(item: car.Number);
                elements.Add(item: car.Owner);
            }

            elements.Sort();

            return string.Join(separator: "_", values: elements);
        }

        public Flyweight GetFlyweight(Car sharedState)
        {
            string key = this.GetKey(car: sharedState);

            if (this.flyweights.All(predicate: t => t.Item2 != key))
            {
                Console.WriteLine(value: "FlyweightFactory: Can't find a flyweight, creating new one.");
                Flyweight flyweight = new(car: sharedState);
                Tuple<Flyweight, string> tuple = new(item1: flyweight, item2: key);
                this.flyweights.Add(item: tuple);
            }
            else
            {
                Console.WriteLine(value: "FlyweightFactory: Reusing existing flyweight.");
            }
            return this.flyweights.First(predicate: t => t.Item2 == key).Item1;
        }

        public void ListFlyweights()
        {
            Console.WriteLine(value: $"\nFlyweightFactory: I have {this.flyweights.Count} flyweights:");
            foreach (Tuple<Flyweight, string> flyweight in this.flyweights)
            {
                Console.WriteLine(value: flyweight.Item2);
            }
        }
    }
}

namespace Flyweight
{
    using System.Text.Json;

    public class Flyweight
    {
        private Car _sharedState;

        public Flyweight(Car car)
        {
            this._sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonSerializer.Serialize(value: this._sharedState);
            string u = JsonSerializer.Serialize(value: uniqueState);
            Console.WriteLine(value: $"Flyweight: Displaying shared \n{s}\n and unique \n{u}\n state.");
        }
    }
}

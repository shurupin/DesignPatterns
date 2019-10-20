namespace Strategy
{
    // Concrete Strategies implement the algorithm while following the base Strategy interface. 
    // The interface makes them interchangeable in the Context.
    class ConcreteStrategy2 : IStrategy
    {
        public object Execute(object data)
        {
            //Apply the Strategy's algorithm
            var result = data.ToString();
            return "Result of ConcreteStrategy2";
        }
    }
}
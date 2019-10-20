using System;

namespace Strategy
{
    class Program
    {
        static void Main()
        {
            // The client code picks a concrete strategy and passes it to the context. 
            // The client should be aware of the differences between strategies in order to make the right choice.
            Context context = new Context();
            object data = new object();
            context.SetData(data);

            // Select strategy
            int strategyNumber = new Random().Next(1, 3);
            switch (strategyNumber)
            {
                case 1:
                    context.SetStrategy(new ConcreteStrategy1());
                    break;
                case 2:
                default:
                    context.SetStrategy(new ConcreteStrategy2());
                    break;
            }

            // Execute strategy
            context.ExecuteStrategy();
        }
    }
}
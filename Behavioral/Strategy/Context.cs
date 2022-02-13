namespace Strategy
{
    using System;

    // The Context defines the interface of interest to clients.
    class Context
    {
        // The context's data
        private object _data;

        // The Context maintains a reference to one of the Strategy objects.
        // The Context does not know the concrete class of a strategy.
        // It should work with all strategies via the Strategy interface.
        private IStrategy _strategy;

        public Context()
        { }

        // Usually, the Context accepts a strategy through the constructor, but
        // also provides a setter to change it at runtime.
        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        // Set the context's data
        public void SetData(object data)
        {
            this._data = data;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void ExecuteStrategy()
        {
            var result = this._strategy.Execute(data: this._data);
            Console.WriteLine(value: result);
        }
    }
}
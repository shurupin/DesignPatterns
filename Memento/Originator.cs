namespace Memento
{
    public class Originator
    {
        /// <summary>
        /// For the sake of simplicity, the originator's state is stored inside a single variable.
        /// </summary>
        private string _state;

        private static readonly Random random = new Random();

        public Originator(string state)
        {
            this._state = state;
            Console.WriteLine(value: $"Originator: My initial state is: {state}");
        }

        /// <summary>
        /// The Originator's business logic may affect its internal state.
        /// Therefore, the client should backup the state before launching
        /// methods of the business logic via the Save() method.
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine(value: "\nOriginator: I'm doing something important.");

            this._state = this.GenerateRandomString(length: 30);

            Console.WriteLine(value: $"Originator: and my state has changed to: {this._state}");
        }

        /// <summary>
        /// Saves the current state inside a memento.
        /// </summary>
        /// <returns>Memento.</returns>
        public IMemento Save()
        {
            return new ConcreteMemento(state: this._state);
        }

        /// <summary>
        /// Restores the Originator's state from a memento object.
        /// </summary>
        /// <param name="memento">Memento.</param>
        public void Restore(IMemento memento)
        {
            if (memento is not ConcreteMemento concreteMemento)
            {
                throw new Exception(message: $"Unknown memento: {memento}");
            }

            this._state = concreteMemento.GetState();
            Console.Write(value: $"Originator: My state has changed to: {this._state}");
        }

        private string GenerateRandomString(int length = 10)
        {
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            char[] randomCharacters = Enumerable.Repeat(element: characters, count: length)
                .Select(selector: s => s[index: random.Next(maxValue: s.Length)])
                .ToArray();

            return new string(value: randomCharacters);
        }
    }
}

namespace Mediator
{
    class Customer : Colleague
    {
        public Customer(Mediator mediator) : base(mediator: mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine(value: $"Message to customer: {message}");
        }
    }
}
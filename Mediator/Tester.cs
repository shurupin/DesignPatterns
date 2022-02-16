namespace Mediator
{
    class Tester : Colleague
    {
        public Tester(Mediator mediator) : base(mediator: mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine(value: $"Message to tester: {message}");
        }
    }
}
namespace Mediator
{
    class Programmer : Colleague
    {
        public Programmer(Mediator mediator) : base(mediator: mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine(value: $"Message to programmer: {message}");
        }
    }
}
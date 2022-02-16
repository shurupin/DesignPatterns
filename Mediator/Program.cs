namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagerMediator mediator = new ManagerMediator();
            Customer customer = new Customer(mediator: mediator);
            Programmer programmer = new Programmer(mediator: mediator);
            Tester tester = new Tester(mediator: mediator);
            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;
            customer.Send(message: "We have an order, need to make a program");
            programmer.Send(message: "I have done program, need to test it");
            tester.Send(message: "I have done testing, here is ready program for you");
        }
    }
}
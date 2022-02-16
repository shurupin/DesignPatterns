namespace Mediator
{
    class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.Customer)
            {
                this.Programmer.Notify(message: message);
            }
            else if (colleague == this.Programmer)
            {
                this.Tester.Notify(message: message);
            }
            else
            {
                this.Customer.Notify(message: message);
            }
        }
    }
}
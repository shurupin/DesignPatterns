namespace Mediator
{
    abstract class Colleague
    {
        protected Mediator Mediator;

        public Colleague(Mediator mediator) => this.Mediator = mediator;

        public virtual void Send(string message) => this.Mediator.Send(message: message, colleague: this);

        public abstract void Notify(string message);

    }
}
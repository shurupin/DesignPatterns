namespace Observer
{
    public abstract class Newspaper
    {
        private readonly List<IUser> _subscribers = new();

        private readonly string _name;
        private decimal _monthlyPrice;

        public Newspaper(string name, decimal monthlyPrice)
        {
            this._name = name;
            this._monthlyPrice = monthlyPrice;
        }

        public decimal MonthlyPrice
        {
            get => this._monthlyPrice;
            set
            {
                if (this._monthlyPrice != value)
                {
                    this._monthlyPrice = value;
                    Console.WriteLine(value: $"Monthly price for {this._name} newspaper is changed to {this._monthlyPrice:C}.");

                    this.Notify();
                }
            }
        }

        public void Subscribe(IUser user)
        {
            this._subscribers.Add(item: user);
            Console.WriteLine(value: $"{user.Name} is subscribed to {this._name} newspaper.");
        }

        public void Unsubscribe(IUser user)
        {
            this._subscribers.Remove(item: user);
            Console.WriteLine(value: $"{user.Name} is unsubscribed from {this._name} newspaper.");
        }

        private void Notify()
        {
            foreach (IUser user in this._subscribers.ToList())
            {
                user.ReportSubscriptionPriceChange(newspaper: this);
            }
        }
    }
}

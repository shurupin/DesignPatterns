namespace Observer
{
    public class User : IUser
    {
        private readonly decimal _availableMonthlySubscriptionAmount;

        public User(string name, decimal availableMonthlySubscriptionAmount)
        {
            this.Name = name;
            this._availableMonthlySubscriptionAmount = availableMonthlySubscriptionAmount;
        }

        public string Name { get; set; }

        public void ReportSubscriptionPriceChange(Newspaper newspaper)
        {
            if (newspaper.MonthlyPrice > this._availableMonthlySubscriptionAmount)
            {
                newspaper.Unsubscribe(user: this);
            }
        }
    }
}

namespace Observer
{
    public interface IUser
    {
        public string Name { get; set; }

        void ReportSubscriptionPriceChange(Newspaper newspaper);
    }
}

namespace Iterator
{
    public class FestivalCollection : IIterableCollection
    {
        private readonly List<MusicFestival> _festivals = new();

        public int Count => this._festivals.Count;

        public void Add(MusicFestival festival)
        {
            this._festivals.Add(item: festival);
        }

        public MusicFestival Get(int index)
        {
            return this._festivals[index: index];
        }

        public IIterator CreateIterator()
        {
            return new FestivalIterator(collection: this);
        }
    }
}

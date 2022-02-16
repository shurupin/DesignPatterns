namespace Iterator
{
    public class FestivalIterator : IIterator
    {
        private readonly FestivalCollection _collection;
        private int _position;
        private int _step;

        public FestivalIterator(FestivalCollection collection)
        {
            this._collection = collection;
            this._position = -1;
            this._step = 1;
        }

        public int Step
        {
            get => this._step;
            set => this._step = value;
        }

        public MusicFestival First()
        {
            this._position = 0;
            return this.Current();
        }

        public MusicFestival Current()
        {
            return this._collection.Get(index: this._position);
        }

        public bool MoveNext()
        {
            int updatedPosition = this._position + this._step;

            if (updatedPosition < this._collection.Count)
            {
                this._position = updatedPosition;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            this._position = -1;
        }
    }
}

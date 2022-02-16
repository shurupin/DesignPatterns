namespace Iterator
{
    public interface IIterator
    {
        int Step { get; set; }

        MusicFestival First();

        MusicFestival Current();

        bool MoveNext();

        void Reset();
    }
}

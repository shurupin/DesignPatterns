namespace Iterator
{
    class Program
    {
        static void Main()
        {
            FestivalCollection collection = new FestivalCollection();

            collection.Add(festival: new MusicFestival(name: "EXIT", country: "Serbia"));
            collection.Add(festival: new MusicFestival(name: "Tomorrowland", country: "Belgium"));
            collection.Add(festival: new MusicFestival(name: "Glastonbury", country: "UK"));
            collection.Add(festival: new MusicFestival(name: "Coachella", country: "USA"));
            collection.Add(festival: new MusicFestival(name: "Woodstock", country: "USA"));

            IIterator iterator = collection.CreateIterator();

            Console.WriteLine(value: "Initial traversal.");
            Traverse(iterator: iterator);

            iterator.Reset();
            iterator.Step = 2;

            Console.WriteLine(value: "\nSecond traversal that should skip every other element.");
            Traverse(iterator: iterator);
        }

        private static void Traverse(IIterator iterator)
        {
            while (iterator.MoveNext())
            {
                MusicFestival festival = iterator.Current();
                Console.WriteLine(value: $"Music festival {festival.Name} takes place in {festival.Country}.");
            }
        }
    }
}
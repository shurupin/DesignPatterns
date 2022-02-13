namespace Facade
{
    public class Dvd
    {
        public Dvd(string name) => this.Movie = name;

        public string Movie { get; }
    }
}
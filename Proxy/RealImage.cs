namespace Proxy
{
    public class RealImage : IDisplay
    {
        private string _fileName;

        public RealImage(string fileName)
        {
            this._fileName = fileName;
            this.LoadFromDisk(fileName: this._fileName);
        }

        public void Display()
        {
            Console.WriteLine(value: "Displaying " + this._fileName);
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine(value: "Loading " + fileName);
        }
    }
}
namespace Proxy
{
    public class ProxyImage : IDisplay
    {
        private RealImage _realImage;
        private string _fileName;

        public ProxyImage(string fileName)
        {
            this._fileName = fileName;
        }

        public void Display()
        {
            if (this._realImage == null)
            {
                this._realImage = new RealImage(fileName: this._fileName);
            }
            this._realImage.Display();
        }
    }
}
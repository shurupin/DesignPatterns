namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IDisplay image = new ProxyImage(fileName: "testImage.jpg");

            //image will be loaded from disk
            image.Display();
            Console.WriteLine(value: "");

            //image will not be loaded from disk
            image.Display();
        }
    }
}

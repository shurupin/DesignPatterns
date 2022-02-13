namespace Facade
{
    using System;

    public class Dimmer
    {
        public void Dim(int percentValue) => Console.WriteLine(value: percentValue == 100 ? "Turning Lights On" : $"Dimming lights to {percentValue}%");
    }
}

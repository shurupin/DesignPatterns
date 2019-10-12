using System;

namespace Facade
{
    public class Dimmer
    {
        public void Dim(int percentValue) => Console.WriteLine(percentValue == 100 ? "Turning Lights On" : $"Dimming lights to {percentValue}%");
    }
}

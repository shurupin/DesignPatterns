namespace Facade
{
    using System;

    public class DvdPlayer
    {
        private Dvd _dvd;

        private int _time = 0;

        public void On() => Console.WriteLine(value: "DVD Player powered on");

        public void Insert(Dvd dvd)
        {
            this._dvd = dvd;
            Console.WriteLine(value: $"Inserting {dvd.Movie}");
        }

        public void Play() => Console.WriteLine(value: $"Playing {this._dvd.Movie}");

        public void Pause() => Console.WriteLine(value: $"Pausing at {this._time = (new Random()).Next(minValue: this._time, maxValue: this._time + 120)}");

        public void Resume() => Console.WriteLine(value: $"Resuming from {this._time}");
    }
}
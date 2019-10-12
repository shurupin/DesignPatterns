using System;

namespace Facade
{
    public class DvdPlayer
    {
        private Dvd _dvd;

        private int _time = 0;

        public void On() => Console.WriteLine("DVD Player powered on");

        public void Insert(Dvd dvd)
        {
            this._dvd = dvd;
            Console.WriteLine($"Inserting {dvd.Movie}");
        }

        public void Play() => Console.WriteLine($"Playing {this._dvd.Movie}");

        public void Pause() => Console.WriteLine($"Pausing at {this._time = (new Random()).Next(this._time, this._time + 120)}");

        public void Resume() => Console.WriteLine($"Resuming from {this._time}");
    }
}
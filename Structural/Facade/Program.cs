namespace Facade
{
    using System;

    internal static class Program
    {
        private static void Main()
        {
            Dimmer dimmer = new Dimmer();
            DvdPlayer dvdPlayer = new DvdPlayer();
            Dvd dvd = new Dvd(name: "The Matrix");
            HomeTheatreFacade homeTheater = new HomeTheatreFacade(dimmer: dimmer, dvd: dvd, dvdPlayer: dvdPlayer);

            homeTheater.WatchMovie();
            Console.WriteLine();

            homeTheater.Pause();
            Console.WriteLine();

            homeTheater.Resume();
            Console.WriteLine();

            homeTheater.Pause();
        }
    }
}
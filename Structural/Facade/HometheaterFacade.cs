namespace Facade
{
    public class HomeTheatreFacade
    {
        private Dimmer _dimmer;
        private Dvd _dvd;
        private DvdPlayer _dvdPlayer;

        public HomeTheatreFacade(Dimmer dimmer, Dvd dvd, DvdPlayer dvdPlayer)
        {
            this._dimmer = dimmer;
            this._dvd = dvd;
            this._dvdPlayer = dvdPlayer;
        }

        public void WatchMovie()
        {
            this._dimmer.Dim(percentValue: 15);
            this._dvdPlayer.On();
            this._dvdPlayer.Insert(dvd: this._dvd);
            this._dvdPlayer.Play();
        }

        public void Pause()
        {
            this._dimmer.Dim(percentValue: 100);
            this._dvdPlayer.Pause();
        }

        public void Resume()
        {
            this._dimmer.Dim(percentValue: 15);
            this._dvdPlayer.Resume();
        }
    }
}
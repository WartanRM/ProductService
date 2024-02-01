namespace ProductService.Models.ViewModels
{
    public interface ITrackRepository
    {
        Track GetTrack(int _);
        IEnumerable<Track> GetTracks();
    }

}

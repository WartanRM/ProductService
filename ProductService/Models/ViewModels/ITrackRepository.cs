namespace ProductService.Models.ViewModels
{
    public interface ITrackRepository
    {
        IEnumerable<Track> GetTracks();
        IEnumerable<Track> GetTrackbyTitle(string _);
        IEnumerable<Track> GetTrackbyAlbum(string _);   
        IEnumerable<Track> GetTrackbyArtist(string _);
        IEnumerable<Track> GetTrackbyGenre(string _);  
        IEnumerable<Track> GetTrackbyYear(string _);

    }

}

using Microsoft.AspNetCore.Mvc;
using ProductService.Models.ViewModels;
using ProductService.Models;

namespace ProductService.Controllers
{
    public class DataController : Controller
    {
        DummyRepository trackRepository;

        public DataController()
        {
            trackRepository = new DummyRepository();

        }


        [HttpGet]
        [Route("Data/Tracks/GetTrackbyTitle")]
        public IEnumerable<Track> GetTrackbyTitle(string title)
        {

            return trackRepository.GetTrackbyArtist(title);
        }

        [HttpGet]
        [Route("Data/Tracks/GetAllTracks")]
        public IEnumerable<Track> GetAllTracks()
        {
            return trackRepository.GetTracks();
        }
        [HttpGet]
        [Route("Data/Tracks/GetTrackbyArtist")]
        public IEnumerable<Track> GetTrackbyArtist(string artistName)
        {

            return trackRepository.GetTrackbyArtist(artistName);
        }

        [HttpGet]
        [Route("Data/Tracks/GetTrackbyAlbum")]
        public IEnumerable<Track> GetTrackbyAlbum(string album)
        {

            return trackRepository.GetTrackbyArtist(album);
        }

    }
}

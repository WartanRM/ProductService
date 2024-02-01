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
        [Route("Data/Tracks/{TrackID}")]
        public Track GetTrack(int TrackID)
        {
            return trackRepository.GetTrack(TrackID);
        }


        [HttpGet]
        [Route("Data/Tracks/GetAllTracks")]
        public IEnumerable<Track> GetAllTracks()
        {
            return trackRepository.GetTracks();
        }


    }
}

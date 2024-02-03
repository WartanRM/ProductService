using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Reflection.PortableExecutable;


namespace ProductService.Models.ViewModels
{
    public class DummyRepository : ITrackRepository
    {
        private List<Track> Tracks;

        public DummyRepository()
        {
            var serializer = new JsonSerializer();
            this.Tracks = new List<Track>();
            using (var streamReader = new StreamReader(@"C:\Users\gokul.wartan\source\repos\ProductService\ProductService\Data\DummyData.json"))
            using (var textReader = new JsonTextReader(streamReader))
            {
                JArray obj = (JArray)JToken.ReadFrom(textReader);
                foreach (var track in obj)
                {
                    Tracks.Add(ConvertToTrack((JObject)track));
                }
            }
        }
        private Track ConvertToTrack(JObject obj)
        {
            Track track = new Track();
            track.Name = (string)obj["Name"];
            track.TrackId = int.Parse((string)obj["TrackID"]);
            track.Album = (string)obj["Album"];
            track.Artists = new List<string>();
            track.Artists.Add((string)obj["Artist"][0]);

            track.Genres = new List<string>();
            track.Genres.Add((string)obj["Genre"][0]);
            return track;

        }
    
        public IEnumerable<Track> GetTrackbyTitle(string title)
        {

            return Tracks.Where(s => s.Name.Contains(title)).ToList(); ;

        }

        public IEnumerable<Track> GetTracks()
            {
                return Tracks;
            }
        public IEnumerable<Track> GetTrackbyArtist(string artist)
        {

            return Tracks.Where(s => s.Artists.Contains(artist)).ToList(); ;

        }

        public IEnumerable<Track> GetTrackbyAlbum(string album)
        {

            return Tracks.Where(s => s.Album.Contains(album)).ToList(); ;

        }

        public IEnumerable<Track> GetTrackbyGenre(string genre)
        {

            return Tracks.Where(s => s.Genres.Contains(genre)).ToList(); 

        }

        public IEnumerable<Track> GetTrackbyYear(string year)
        {

            return Tracks.Where(s => s.Year.Contains(year)).ToList();

        }

    }
}

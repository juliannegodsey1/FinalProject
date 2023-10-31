using Microsoft.AspNetCore.Mvc;

namespace MusicApp
{
    public class Artist : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TrackArtist()
        {
            var artist = MusicAppClass2.DeezerArtistID(artistID);
            return View(artist);
        }
    }
}

using RestSharp;
using Newtonsoft.Json.Linq;


namespace MusicApp
{
    public class MusicAppClass2
    {


        public static RestResponse DeezerArtistID(string artistId)
        {
            var client = new RestClient($"https://deezerdevs-deezer.p.rapidapi.com/artist/{artistId}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "aa89a0583amsh1788e060f62f281p1e80b1jsn215f253cc0c5");
            request.AddHeader("X-RapidAPI-Host", "deezerdevs-deezer.p.rapidapi.com");
            RestResponse response = client.Execute(request);

            return response;
        }



        public static RestResponse DeezerSearchWord(string searchTrack)
        {
            var client = new RestClient($"https://deezerdevs-deezer.p.rapidapi.com/search?q={searchTrack}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "aa89a0583amsh1788e060f62f281p1e80b1jsn215f253cc0c5");
            request.AddHeader("X-RapidAPI-Host", "deezerdevs-deezer.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            return response;
        }

        public static RestResponse DeezerAlbum(string albumName)
        {
            var client = new RestClient($"https://deezerdevs-deezer.p.rapidapi.com/album/{albumName}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "aa89a0583amsh1788e060f62f281p1e80b1jsn215f253cc0c5");
            request.AddHeader("X-RapidAPI-Host", "deezerdevs-deezer.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            return response;
        }

        public static RestResponse DeezerPlaylist (string playlistName)
        {
            var client = new RestClient($"https://deezerdevs-deezer.p.rapidapi.com/playlist/{playlistName}");
            var request = new RestRequest("", Method.Get);
            request.AddHeader("X-RapidAPI-Key", "aa89a0583amsh1788e060f62f281p1e80b1jsn215f253cc0c5");
            request.AddHeader("X-RapidAPI-Host", "deezerdevs-deezer.p.rapidapi.com");
            RestResponse response = client.Execute(request);
            return response;
        }


       

    }
}


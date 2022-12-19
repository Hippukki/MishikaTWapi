using MishikaTWapi.Entities;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MishikaTWapi.Logic
{
    public class RequestHandler : IRequestHandler
    {
        private readonly HttpClient httpClient;

        public RequestHandler(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<string> GetAdviceAsync()
        {
            var advice = await httpClient.GetStringAsync("https://api.scorpstuff.com/advice.php");
            return advice;
        }

        public async Task<string> GetDadJokeAsync()
        {
            var dadjoke = await httpClient.GetStringAsync("https://api.scorpstuff.com/dadjokes.php");
            return dadjoke;
        }

        public async Task<string> GetDogFactAsync()
        {
            var dogfact = await httpClient.GetStringAsync("https://api.scorpstuff.com/dogfacts.php");
            return dogfact;
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            var weather = await httpClient.GetStringAsync($"https://api.scorpstuff.com/weather.php?units=metric&city={city}");
            return weather;
        }
         
    }
}

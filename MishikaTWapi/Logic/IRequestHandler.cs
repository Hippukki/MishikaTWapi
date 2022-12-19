using MishikaTWapi.Entities;
using System.Threading.Tasks;

namespace MishikaTWapi.Logic
{
    public interface IRequestHandler
    {
        Task<string> GetDadJokeAsync();
        Task<string> GetAdviceAsync();
        Task<string> GetDogFactAsync();
        Task<string> GetWeatherAsync(string city);
    }
}

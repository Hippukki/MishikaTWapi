using System.Threading.Tasks;

namespace MishikaTWapi.Logic
{
    public interface ITranslator
    {
        Task<string> TranslateAsync(string request);
    }
}

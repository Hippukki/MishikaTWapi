using MishikaTWapi.Entities;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MishikaTWapi.Logic
{
    public class Translator : ITranslator
    {
        private readonly HttpClient httpClient;

        public Translator(HttpClient httpClient)
        {
            httpClient.DefaultRequestHeaders.Add("Authorization", "Api-Key Not so fast, scoundrel!");
            this.httpClient = httpClient;
        }

        public async Task<string> TranslateAsync(string request)
        {
            TranslationRequest translation = new()
            {
                Texts = new string[] { request }
            };
            var response = await httpClient.PostAsJsonAsync("https://translate.api.cloud.yandex.net/translate/v2/translate", translation);
            var responseBody = await response.Content.ReadAsStringAsync();

            var obstring = responseBody.Remove(0, 36);
            var finalstring = obstring
                .Replace("]", String.Empty)
                .Replace("}", String.Empty);

            return finalstring;
        }
    }
}

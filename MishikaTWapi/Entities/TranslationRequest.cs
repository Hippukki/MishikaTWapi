using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace MishikaTWapi.Entities
{
    public class TranslationRequest
    {

        private readonly string _sourceLanguageCode = "en";
        public string SourceLanguageCode { get => _sourceLanguageCode;}

        private readonly string _targetLanguageCode = "ru";
        public string TargetLanguageCode { get => _targetLanguageCode;}

        public readonly string _format = "PLAIN_TEXT";
        public string Format { get => _format;}

        public string[] Texts { get; set; }

    }
}

using Microsoft.AspNetCore.Mvc;
using MishikaTWapi.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MishikaTWapi.Controllers
{
    [Route("Mishika")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        private readonly IRequestHandler requestHandler;

        private readonly ITranslator translator;

        public RequestController(IRequestHandler requestHandler, ITranslator translator)
        {
            this.requestHandler = requestHandler;
            this.translator = translator;
        }

        [HttpGet("advice")]
        public async Task<string> GetAdviceAsync()
        {
            var advice = await requestHandler.GetAdviceAsync();
            return await translator.TranslateAsync(advice);
        }
        [HttpGet("dadjoke")]
        public async Task<string> GetDadJokeAsync()
        {
            var dadjoke = await requestHandler.GetDadJokeAsync();
            return await translator.TranslateAsync(dadjoke);
        }
        [HttpGet("dogfact")]
        public async Task<string> GetDogFactAsync()
        {
            var dogfact = await requestHandler.GetDogFactAsync();
            return await translator.TranslateAsync(dogfact);
        }
        [HttpGet("weather")]
        public async Task<string> GetWeatherAsync(string city)
        {
            var weather = await requestHandler.GetWeatherAsync(city);
            return await translator.TranslateAsync(weather);
        }
    }
}

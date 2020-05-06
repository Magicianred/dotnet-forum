using DotnetForum.Contracts.Services;
using Microsoft.Extensions.Logging;
using System;

namespace DotnetForum.WebApi.Services
{
    public class RandomizerService : IRandomizerService
    {
        private readonly ILogger<IRandomizerService> _logger;

        private readonly Random _random;

        public RandomizerService(ILogger<IRandomizerService> logger)
        {
            _logger = logger;

            _random = new Random();
        }        

        public int GetNextNumber(int? min, int? max)
        {
            if (min.HasValue)
            {
                if (max.HasValue)
                {
                    _logger.LogDebug("min, max specified.");
                    return _random.Next(min.Value, max.Value);
                }
                else
                {
                    _logger.LogDebug("min specified.");
                    return _random.Next(min.Value);
                }
            }
            else
            {
                if (max.HasValue)
                {
                    _logger.LogDebug("max specified.");
                    return _random.Next(max.Value);
                }
                else
                {
                    _logger.LogDebug("not specified.");
                    return _random.Next();
                }
            }
        }
    }
}

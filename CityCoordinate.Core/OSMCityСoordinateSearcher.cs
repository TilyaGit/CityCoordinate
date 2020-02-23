using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CityCoordinate.Core
{
    public class OSMCityСoordinateSearcher : ICityСoordinateSearcher
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public OSMCityСoordinateSearcher(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory ??
                                 throw new ArgumentNullException(nameof(httpClientFactory));
        }
        public async Task<List<CityСoordinateInfo>> GetСoordinate(string city)
        {
            using (var httpClient = _httpClientFactory.CreateClient())
            {
                var cityName = city.ToLower();

                var strUrl = $"https://nominatim.openstreetmap.org/search?format=json&q={cityName}";

                httpClient.DefaultRequestHeaders.Add("User-Agent", "Tunduk");

                var result = await httpClient.GetStringAsync(strUrl);

                var desList = JsonConvert.DeserializeObject<List<CityСoordinateInfo>>(result);

                return desList;
            }
        }
    }
}

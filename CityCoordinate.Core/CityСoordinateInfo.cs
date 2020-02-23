using Newtonsoft.Json;

namespace CityCoordinate.Core
{

    public class CityСoordinateInfo
    {
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; } 

        public double Lat { get; set; }

        public double Lon { get; set; }
    }
}

using MongoDB.Bson.Serialization.Attributes;

namespace CityCoordinate.Api
{
    public class CityСoordinateKey
    {
        [BsonId]
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

    }
}

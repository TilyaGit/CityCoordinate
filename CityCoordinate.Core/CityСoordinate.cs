using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CityCoordinate.Core
{
    public class CityСoordinate
    {
        [BsonId]
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

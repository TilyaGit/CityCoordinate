using MongoDB.Bson.Serialization.Attributes;

namespace CityCoordinate.Core
{
    public class CityСoordinate
    {
        [BsonId]
        //[BsonElement("display_name")]
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}

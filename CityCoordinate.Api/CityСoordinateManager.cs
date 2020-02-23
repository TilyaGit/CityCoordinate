using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CityCoordinate.Core;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace CityCoordinate.Api
{
    public class CityСoordinateManager : ICityСoordinateManager
    {
        private readonly IMongoCollection<CityСoordinate> _collection;
        public CityСoordinateManager(IConfiguration configuration)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("cityCoordinate");
            _collection = db.GetCollection<CityСoordinate>("coordinates");
        }

        public void SaveList(IList<CityСoordinate> cityСoordinates)
        {
            throw new NotImplementedException();
        }

        public async Task<CityСoordinate> GetList()
        {
            return await _collection.Find(сoordinate => true).FirstAsync();
        }
        public async Task<CityСoordinate> CheckList(string city)
        {
            return  await _collection.Find(coordinate
            => coordinate.Name == city).FirstOrDefaultAsync();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace CityCoordinate.Api.IRepository
{
    public class CityСoordinateRepository : ICityСoordinateRepository
    {
        private readonly CityCoordinateContext _configuration = null;

        public CityСoordinateRepository(IOptions<Settings> options)
        {
            _configuration = new CityCoordinateContext(options);
        }
        public async Task<CityСoordinateKey> CheckList(string city)
        {
            var coor = Builders<CityСoordinateKey>.Filter.Eq("display_name", city);
            return await _configuration.CityСoordinateKeys.Find(coor).FirstOrDefaultAsync();
        }
    }
}

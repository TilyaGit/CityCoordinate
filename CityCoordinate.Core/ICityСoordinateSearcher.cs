using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace CityCoordinate.Core
{
    public interface ICityСoordinateSearcher
    {
        [ItemNotNull]
        Task<List<CityСoordinateInfo>> GetСoordinate(string city);
    }
}

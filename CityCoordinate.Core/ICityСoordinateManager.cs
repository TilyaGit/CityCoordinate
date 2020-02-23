using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityCoordinate.Core
{
    public interface ICityСoordinateManager
    {
        void SaveList(IList<CityСoordinate> cityСoordinates);

        Task<CityСoordinate> CheckList(string city);
        Task<CityСoordinate> GetList();

    }
}

using System.Collections.Generic;
using System.Threading.Tasks;

namespace CityCoordinate.Core
{
    public interface ICityСoordinateManager
    {
        void SaveList(IList<CityСoordinate> cityСoordinates);

        IList<CityСoordinate> CheckList(string city);
        IList<CityСoordinate> GetList();

    }
}

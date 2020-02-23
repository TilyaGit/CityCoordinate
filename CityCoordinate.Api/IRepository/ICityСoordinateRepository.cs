using System.Threading.Tasks;

namespace CityCoordinate.Api.IRepository
{
    public interface ICityСoordinateRepository
    {
        Task<CityСoordinateKey> CheckList(string city);

    }
}

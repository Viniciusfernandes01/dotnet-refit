using Refit.API.Domain.Model;
using System.Threading.Tasks;

namespace Refit.API.Domain.Interfaces.Services
{
    public interface IStarshipsService
    {
        Task<Starship> GetStarship(string id);
    }
}

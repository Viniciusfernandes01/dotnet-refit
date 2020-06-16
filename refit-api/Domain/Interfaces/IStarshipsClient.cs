using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using Refit.API.Domain.Model;

namespace Refit.API.Domain.Interfaces.Services
{
    public interface IStarshipsClient
    {
        [Get("/starships/{id}/")]
        Task<Starship> GetStarship(string id);
    }
}

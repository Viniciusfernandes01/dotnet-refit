using Refit.API.Domain.Interfaces.Services;
using Refit.API.Domain.Model;
using System.Threading.Tasks;

namespace Refit.API.Services
{
    public class StarshipsService : IStarshipsService
    {
        private readonly IStarshipsClient _starshipsClient;

        public StarshipsService(IStarshipsClient starshipsClient)
        {
            _starshipsClient = starshipsClient;
        }

        public async Task<Starship> GetStarship(string id)
        {
            return await _starshipsClient.GetStarship(id);
        }
    }
}

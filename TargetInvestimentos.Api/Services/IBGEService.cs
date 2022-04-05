using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;

namespace TargetInvestimentos.Api.Services
{
    public class IBGEService : IIBGEService
    {
        public Task<ICollection<City>> GetAllCities(string uf)
        {

            throw new NotImplementedException();
        }

        public Task<ICollection<State>> GetAllStates()
        {

            throw new NotImplementedException();
        }
    }
}

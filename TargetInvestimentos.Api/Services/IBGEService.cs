using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;
using PetrusPackage;

namespace TargetInvestimentos.Api.Services
{
    public class IBGEService : IIBGEService
    {
        public Task<ICollection<City>> GetAllCities(string uf)
        {

            throw new NotImplementedException();
        }

        public async Task<ICollection<State>> GetAllStates()
        {
            var response  = await Petrus.Get("https://servicodados.ibge.gov.br/api/v1/localidades/estados");

            return response.Data.ToObject<List<State>>();
        }
    }
}

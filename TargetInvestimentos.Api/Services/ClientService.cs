using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;
using TargetInvestimentos.Infrastructure;

namespace TargetInvestimentos.Api.Services
{
    public class ClientService : IClientService
    {

        private readonly Context _context;
        public ClientService(Context context)
        {
            _context = context;
        }

        public Task<Address> GetClientAddress(int id)
        {
            throw new NotImplementedException();
        }

        public Task RegisterClient(Person p)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClient(Person p)
        {
            throw new NotImplementedException();
        }
    }
}

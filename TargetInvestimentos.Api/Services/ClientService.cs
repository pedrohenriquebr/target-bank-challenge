using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;
using TargetInvestimentos.Domain.Validations;
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

        public async Task RegisterClient(Person p)
        {
            var isValidCPF = ClientValidations.ValidateCPF(p.Cpf);
            var isValidCEP = ClientValidations.ValidateCEP(p.Address.CD_PostalCode);
            var errorResponse = string.Empty;

            if (!isValidCPF)
            {
                errorResponse += "CPF informado não tem formato válido\n";
            }

            if (!isValidCEP)
            {
                errorResponse += "CEP informado não tem formato válido";
            }

            if (!string.IsNullOrEmpty(errorResponse))
            {
                throw new Exception(errorResponse);
            }

            await _context.Person.AddAsync(p);
            
        }

        public Task UpdateClient(Person p)
        {
            throw new NotImplementedException();
        }
    }
}

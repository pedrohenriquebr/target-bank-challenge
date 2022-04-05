using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetInvestimentos.Domain.Entities;

namespace TargetInvestimentos.Domain.Interfaces
{
    public interface IClientService
    {
        public Task RegisterClient(Person p);

        public Task UpdateClient(Person p);

        public Task<Address> GetClientAddress(int id);

    }
}

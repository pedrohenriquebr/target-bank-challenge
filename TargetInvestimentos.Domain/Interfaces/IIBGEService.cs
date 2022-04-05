using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetInvestimentos.Domain.Entities;

namespace TargetInvestimentos.Domain.Interfaces
{
    public interface IIBGEService
    {

        public Task<ICollection<State>> GetAllStates();
        public Task<ICollection<City>> GetAllCities(string uf);
    }
}

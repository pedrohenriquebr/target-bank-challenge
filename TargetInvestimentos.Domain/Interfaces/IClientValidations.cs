using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetInvestimentos.Domain.Interfaces
{
    public interface IClientValidations
    {
        public static bool ValidateCPF(string cpf) => throw new NotImplementedException();
        public static bool ValidateCEP(string cep) =>  throw new NotImplementedException();
    }
}

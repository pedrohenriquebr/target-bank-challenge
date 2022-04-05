using TargetInvestimentos.Api.Models;
using TargetInvestimentos.Domain.Entities;

namespace TargetInvestimentos.Api.Adapters
{
    public class InvestimentosAdapter
    {

        public static Person RegisterModelToEntity(RegisterClientCommand command)
        {
            return new Person
            {
                NM_FullName = command.nomeCompleto,
                DT_BirthDate = command.dataNascimento,
                Cpf = command.cpf,
                MonthlyIncome = command.rendaMensal,
                Address = new Address
                {
                    CD_PostalCode = command.cep,
                    CD_StateAcronym = command.uf,
                    NM_State = command.estado,
                    DS_Complement = command.complemento,
                    DS_PublicPlace = command.logradouro,
                    NM_City = command.cidade,
                    NM_District = command.bairro
                }
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TargetInvestimentos.Domain.Entities;
using TargetInvestimentos.Domain.Interfaces;

namespace TargetInvestimentos.Domain.Validations
{
    public class ClientValidations : IClientValidations
    {
        /// <summary>
        ///  Valida formato de CEP
        ///  
        /// Fonte: https://social.msdn.microsoft.com/Forums/pt-BR/7c954e00-4461-4796-a7fa-767cc2a06176/funo-para-validar-cep-?forum=vscsharppt
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static bool ValidateCEP(string cep)
        {
            var Rgx = new Regex("^\\d{5}-\\d{3}$");

            if (!Rgx.IsMatch(cep))
                return false;
            return true;
        }

        /// <summary>
        ///  Valida se CPF é válido
        ///  
        ///  Fonte: https://www.macoratti.net/11/09/c_val1.htm
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        public static bool ValidateCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            try
            {
                cpf = cpf.Trim();
                cpf = cpf.Replace(".", "").Replace("-", "");
                if (cpf.Length != 11)
                    return false;
                tempCpf = cpf.Substring(0, 9);
                soma = 0;

                for (int i = 0; i < 9; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = resto.ToString();
                tempCpf = tempCpf + digito;
                soma = 0;
                for (int i = 0; i < 10; i++)
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                resto = soma % 11;
                if (resto < 2)
                    resto = 0;
                else
                    resto = 11 - resto;
                digito = digito + resto.ToString();
            }
            catch (System.FormatException e)
            {
                return false;
            }

            return cpf.EndsWith(digito);
        }

        public static bool ValidateIsVip(Person person)
        {
            return person.MonthlyIncome >= 6_000;
        }
    }
}

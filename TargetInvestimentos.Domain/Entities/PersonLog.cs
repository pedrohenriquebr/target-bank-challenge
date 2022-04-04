using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetInvestimentos.Domain.Entities
{
    public class PersonLog
    {
        [Key]
        public int ID_PersonLog { get; set; }
        public int ID_Person { get; set; }

        [StringLength(1)]
        public string CD_TypeLog { get; set; }

        public int ID_Address { get; set; }

        public DateTime DT_BirthDate { get; set; }

        public DateTime DT_RegisterDate { get; set; }

        [StringLength(200)]
        public string NM_FullName { get; set; }

        public bool IS_Vip { get; set; }

        public decimal MonthlyIncome { get; set; }

        [StringLength(8)]
        public string Cpf { get; set; }
    }
}

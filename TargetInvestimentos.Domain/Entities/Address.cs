using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetInvestimentos.Domain.Entities
{
    public class Address
    {
        [Key]
        public int ID_Address { get; set; }

        [StringLength(8)]
        public string CD_PostalCode { get; set; }

        [StringLength(100)]
        public string NM_State { get; set; }

        [StringLength(2)]
        public string CD_StateAcronym { get; set; }

        [StringLength(200)]
        public string DS_PublicPlace { get; set; }

        [StringLength(200)]
        public string NM_City { get; set; }

        [StringLength(200)]
        public string DS_Complement { get; set; }

        [StringLength(200)]
        public string NM_District { get; set; }

        public virtual Person Person { get; set; }
    }
}

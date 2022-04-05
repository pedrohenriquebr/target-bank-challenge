using System.ComponentModel.DataAnnotations;

namespace TargetInvestimentos.Api.Models
{
    public class RegisterClientCommand
    {
        [Required]
        public string fullName { get; set; }

        [Required]
        public DateTime birthDate { get; set; }

        [Required]
        public string cpf { get; set; }
    }
}

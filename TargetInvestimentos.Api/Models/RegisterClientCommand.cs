using System.ComponentModel.DataAnnotations;

namespace TargetInvestimentos.Api.Models
{
    public class RegisterClientCommand
    {
        [Required]
        public string nomeCompleto { get; set; }

        [Required]
        public DateTime dataNascimento { get; set; }

        [Required]
        public decimal rendaMensal { get; set; }

        [Required]
        public string cpf { get; set; }

        [Required]
        public string logradouro { get; set; }

        [Required]
        public string bairro { get; set; }

        [Required]
        public string cep { get; set; }

        [Required]
        public string uf { get; set; }

        [Required]
        public string estado { get; set; }

        [Required]
        public string complemento { get; set; }
    }
}

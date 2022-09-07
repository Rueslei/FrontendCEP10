using System.ComponentModel.DataAnnotations;

namespace MeuWebApp.Models
{
    public class Endereco
    {
        [Required(ErrorMessage ="O campo {0} é de preenchimento obrigatório.")]
        [RegularExpression(@"[0-9]{8}$", ErrorMessage ="O campo {0} deve ser preenchio com 8 dígitos numéricos.")]
        public int CEP { get; set; }

        public string Estado { get; set; }
         
        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }
            
    }
}

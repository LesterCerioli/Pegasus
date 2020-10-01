using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.Fornecedor
{
    public class FornecedorResponse
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "informe o Nome do Fornecedor")]
        [MinLength(10)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = ("Informe a Razão Social"))]
        [MinLength(10)]
        [MaxLength(100)]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "informe o Número de telefone")]
        [MinLength(8)]
        [MaxLength(20)]
        [DisplayName("Telefone")]
        public string Telefone { get; set; }
        
        [Required(ErrorMessage = "Informe o Nome do Contato")]
        [MinLength(10)]
        [MaxLength(100)]
        [DisplayName("Contato")]
        public string Contato { get; set; }
        
        
        [Required(ErrorMessage = "Informe o Logradouro")]
        [MinLength(10)]
        [MaxLength(100)]
        [DisplayName("Logradouro")]
        public string Logradouro { get; set; }
        
        [DisplayName("Número")]
        public string Numero { get; set; }
        
        [DisplayName("Complemento")]
        [MaxLength(100)]
        public string Complemento { get; set; }
        
        [DisplayName("CEP")]
        [MaxLength(15)]
        public string Cep { get; set; }
        
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }

    }
}

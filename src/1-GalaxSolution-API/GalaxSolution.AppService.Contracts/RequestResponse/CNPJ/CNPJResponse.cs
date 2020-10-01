using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.CNPJ
{
    public class CNPJResponse
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O número do documento deve ser informado")]
        public string NumCNPJ { get; set; }

    }
}

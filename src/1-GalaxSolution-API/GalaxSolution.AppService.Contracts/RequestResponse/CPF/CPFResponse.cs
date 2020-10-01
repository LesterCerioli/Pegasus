using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.CPF
{
    public class CPFResponse
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O número do documento deve ser informado")]
        public string NumCPF { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.Cidade
{
    public class CidadeResponse
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome da cidadedeve ser informado")]
        [MinLength(15)]
        [MaxLength(100)]
        [DisplayName("Nome")]
        public string Nome { get; set; }


        public bool Ativo { get; set; }

    }
}

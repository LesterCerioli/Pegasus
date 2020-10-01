using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.EntradaProduto
{
    public class EntradaProdutoResponse
    {
        [Key]
        public Guid Guid { get; set; }
        
        [Required(ErrorMessage = "O número de referência deve ser informado")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "A Data deve ser informada")]
        public DateTime Data { get; set; }
        
        [Required(ErrorMessage = "A Quantidade deve ser informada")]
        public int Quantidade { get; set; }
    }
}

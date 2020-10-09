using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.EntradaProduto
{
    public class ProductInputResponse
    {
        [Key]
        public Guid Guid { get; set; }
        
        [Required(ErrorMessage = "O número de referência deve ser informado")]
        public string Numeber { get; set; }
        [Required(ErrorMessage = "A Data deve ser informada")]
        public DateTime Date { get; set; }
        
        [Required(ErrorMessage = "A Quantidade deve ser informada")]
        public int Amount { get; set; }
    }
}

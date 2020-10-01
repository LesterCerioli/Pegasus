using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.Estado
{
    public class EstadoResponse
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "O nome do Estado deve ser preenchido")]
        [MinLength(4)]
        [MaxLength(50)]
        [DisplayName("Estado")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "A SAigla do Estado deve ser informadao")]
        [MaxLength(2)]
        [DisplayName("UF")]
        public string UF { get; set; }
        
        
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}

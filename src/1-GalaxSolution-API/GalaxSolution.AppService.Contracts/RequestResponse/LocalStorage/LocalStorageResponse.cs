using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.LocalStorage
{
    public class LocalStorageResponse
    {
        [Key]
        public Guid Id { get; set; }
        //tst
        [Required(ErrorMessage = "O nome do local de armazenamento deve ser informado")]
        [MinLength(15)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }


        public bool Actived { get; set; }
    }
}

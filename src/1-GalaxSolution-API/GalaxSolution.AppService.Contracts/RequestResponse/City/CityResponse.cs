using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GalaxSolution.AppService.Contracts.RequestResponse.City
{
    public class CityResponse
    {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O nome da cidadedeve ser informado")]
        [MinLength(15)]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }


        public bool Actived { get; set; }

    }
}

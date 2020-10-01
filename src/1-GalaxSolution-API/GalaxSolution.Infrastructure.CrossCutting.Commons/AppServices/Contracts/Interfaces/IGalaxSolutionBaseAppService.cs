
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.Infrastructure.CrossCutting.Commons.AppServices.Contracts.Interfaces
{
    public interface IGalaxSolutionBaseAppService
    {
        string User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.Interfaces
{
    public interface ICPFAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<CPFResponse>> ListCPFAsync(DateTime startData, DateTime endData)/
        
    }
}

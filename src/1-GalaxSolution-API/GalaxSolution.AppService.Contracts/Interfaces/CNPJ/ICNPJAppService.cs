using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.Interfaces.CNPJ
{
    public interface ICNPJAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<CNPJResponse>> ListCNPJAsync(DateTime startData, DateTime endData)/

    }
    
}

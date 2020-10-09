using GalaxSolution.AppService.Contracts.RequestResponse.Cidade;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.AppService.Contracts.Interfaces.Cidade
{
    public interface ICidadeAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<CidadeResponse>> ListCidadeAsync(DateTime startData, DateTime endData);
    }
}

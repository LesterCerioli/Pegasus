using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.Interfaces.Fornecedor
{
    public interface IFornecedorAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<FornecedorResponse>> ListFornecedorAsync(DateTime startData, DateTime endData)/
    }
}

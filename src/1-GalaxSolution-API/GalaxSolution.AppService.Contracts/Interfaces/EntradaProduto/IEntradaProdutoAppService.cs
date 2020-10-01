using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.Interfaces.EntradaProduto
{
    public interface IEntradaProdutoAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<EntradaProdutoResponse>> ListEntradaProdutoAsync(DateTime startData, DateTime endData)/
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GalaxSolution.AppService.Contracts.Interfaces.Estado
{
    public interface IEstadoAppService : IGalaxSolutionBaseAppService, IDisposable
    {
        Task<ResponseMessage<IEnumerable<EstadoResponse>> ListEstadoAsync(DateTime startData, DateTime endData)/
    }
}

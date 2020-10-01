using GalaxSolution.AppService.Contracts.RequestResponse.Cidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.AppService.Contracts.Interfaces.Cidade
{
    public interface ICidadeAppService : IDisposable
    {
        Task<IEnumerable<CidadeResponse>> GetAll();
        Task<CidadeResponse> GetById(Guid id);

        Task<ValidationResult> Add(CidadeResponse cidadeResponse);
        Task<ValidationResult> Update(CidadeResponse cidadeResponse);
        Task<ValidationResult> Remove(CidadeResponse cidadeResponse);

        Task<IList<CidadeHistoryData>> GetAllHistory(Guid id);
    }
}

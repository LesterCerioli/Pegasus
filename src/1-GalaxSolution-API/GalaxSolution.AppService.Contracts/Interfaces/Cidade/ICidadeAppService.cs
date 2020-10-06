using GalaxSolution.AppService.Contracts.EventSourcedNormalizers.Cidade;
using GalaxSolution.AppService.Contracts.RequestResponse.Cidade;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GalaxSolution.AppService.Contracts.Interfaces.Cidade
{
    public interface ICidadeAppService : IDisposable
    {
<<<<<<< HEAD
        Task<IEnumerable<CidadeResponse>> GetAll();
        Task<CidadeResponse> GetById(Guid id);

        Task<ValidationResult> Add(CidadeResponse cidadeResponse);
        Task<ValidationResult> Update(CidadeResponse cidadeResponse);
        Task<ValidationResult> Remove(CidadeResponse cidadeResponse);

        Task<IList<CityHistoryData>> GetAllHistory(Guid id);
=======
        Task<ResponseMessage<IEnumerable<CidadeResponse>> ListCidadeAsync(DateTime startData, DateTime endData);
Task<CidadeResponse> GetById(Guid id);
        Task<IEnumerable<CidadeResponse>> GetAll();
>>>>>>> 5ce00386b4f8ce8480d962a96ebe9c67a8d86a72
    }
}

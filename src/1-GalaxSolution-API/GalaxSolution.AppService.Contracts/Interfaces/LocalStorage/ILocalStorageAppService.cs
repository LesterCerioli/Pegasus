using GalaxSolution.AppService.Contracts.EventSourcedNormalizers.LocalStorage;
using GalaxSolution.AppService.Contracts.RequestResponse.LocalStorage;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace GalaxSolution.AppService.Contracts.Interfaces.LocalArmazenamento
{
    public interface ILocalStorageAppService
    {
        Task<IEnumerable<LocalStorageResponse>> GetAll();
        Task<LocalStorageResponse> GetById(Guid id);

        Task<ValidationResult> Add(LocalStorageResponse localStorageResponse);
        Task<ValidationResult> Update(LocalStorageResponse localStorageResponse);
        Task<ValidationResult> Remove(LocalStorageResponse localStorageResponse);

        Task<IList<LocalStorageHistoryData>> GetAllHistory(Guid id);
    }
}

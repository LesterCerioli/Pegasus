using GalaxSolution.AppService.Contracts.EventSourcedNormalizers.City;
using GalaxSolution.AppService.Contracts.RequestResponse.City;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace GalaxSolution.AppService.Contracts.Interfaces.City
{
    public interface ICityAppService : IDisposable
    {

        Task<IEnumerable<CityResponse>> GetAll();
        Task<CityResponse> GetById(Guid id);

        Task<ValidationResult> Add(CityResponse cityResponse);
        Task<ValidationResult> Update(CityResponse cityResponse);
        Task<ValidationResult> Remove(CityResponse cityResponse);

        Task<IList<CityHistoryData>> GetAllHistory(Guid id);

        Task<CityResponse<IEnumerable<CityResponse>> ListCityAsync(DateTime startData, DateTime endData);
        Task<CityResponse> GetById(Guid id);
        Task<IEnumerable<CityResponse>> GetAll();

    }
}

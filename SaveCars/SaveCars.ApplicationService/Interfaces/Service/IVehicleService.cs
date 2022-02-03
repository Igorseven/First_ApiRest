using SaveCars.ApplicationService.Request.Vehicle;
using SaveCars.ApplicationService.Response;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IVehicleService : IBaseService<VehicleRequest, VehicleSearchRequest, VehicleResponse>
    {
        Task<SearchResponse<VehicleResponse>> FindVehiclesAndAllTheDetailsAsync(VehicleSearchRequest searchRequest);
        Task<VehicleResponse> FindVehicleAndDatailsAsync(VehicleSearchRequest searchRequest);
    }
}

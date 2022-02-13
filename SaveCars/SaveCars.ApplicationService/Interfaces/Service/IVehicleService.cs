using SaveCars.ApplicationService.Request.Vehicle;
using SaveCars.ApplicationService.Response;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IVehicleService : IBaseService<VehicleSaveRequest, VehicleUpdateRequest, VehicleSearchRequest, VehicleResponse>
    {
    }
}

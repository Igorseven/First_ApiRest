using SaveCars.ApplicationService.AutoMapperSettings;
using SaveCars.ApplicationService.Interfaces.Service;
using SaveCars.ApplicationService.Request.Vehicle;
using SaveCars.ApplicationService.Response;
using SaveCars.Business.Interfaces.NotificationHandler;
using SaveCars.Business.Interfaces.Repository;
using SaveCars.Business.Interfaces.ValidationHandler;
using SaveCars.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Services
{
    public class VehicleService : BaseService<Vehicle>, IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(INotificationContext notification, IValidation<Vehicle> validation, IVehicleRepository vehicleRepository)
            : base(notification, validation)
        {
            this._vehicleRepository = vehicleRepository;
        }


        public async Task<int> SaveAsync(VehicleSaveRequest request)
        {
            var vehicle = request.MapTo<VehicleSaveRequest, Vehicle>();

            if (!await ValidatedAsync(vehicle))
            {
                return 0;
            }

            return await this._vehicleRepository.CreateAsync(vehicle);
        }

        public async Task<int> UpdateAsync(VehicleUpdateRequest request)
        {
            var vehicleUpdate = request.MapTo<VehicleUpdateRequest, Vehicle>();

            if (!await ValidatedAsync(vehicleUpdate))
            {
                return 0;
            }

            return await this._vehicleRepository.UpdateAsync(vehicleUpdate);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await this._vehicleRepository.DeleteAsync(id);
        }


        public async Task<SearchResponse<VehicleResponse>> FindAllAsync()
        {
            var vehicles = await this._vehicleRepository.FindAllAsync();
            return new SearchResponse<VehicleResponse> {
                Entities = vehicles.MapTo<IEnumerable<Vehicle>, IEnumerable<VehicleResponse>>(),
                TotalEntities = 10
            };
        }
        public async Task<VehicleResponse> FindByAsync(int id)
        {
            var vehicle = await this._vehicleRepository.FindByAsync(id);
            var response = vehicle.MapTo<Vehicle, VehicleResponse>();

            return response;
        }

        public async Task<VehicleResponse> FindByAsync(VehicleSearchRequest searchRequest)
        {
            var vehicle = await this._vehicleRepository.FindByAsync(x => x.Model == searchRequest.Model);
            var response = vehicle.MapTo<Vehicle, VehicleResponse>();

            return response;
        }
    }
}

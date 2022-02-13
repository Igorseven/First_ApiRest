using AutoMapper;
using SaveCars.ApplicationService.Request.Vehicle;
using SaveCars.ApplicationService.Response;
using SaveCars.Domain.Entities;

namespace SaveCars.ApplicationService.AutoMapperSettings.EntitiesProfiles
{
    public class VehicleProfile : Profile
    {
        public VehicleProfile()
        {
            CreateMap<Vehicle, VehicleSaveRequest>().ReverseMap();

            CreateMap<Vehicle, VehicleUpdateRequest>().ReverseMap();

            CreateMap<Vehicle, VehicleResponse>().ReverseMap();
        }
    }
}

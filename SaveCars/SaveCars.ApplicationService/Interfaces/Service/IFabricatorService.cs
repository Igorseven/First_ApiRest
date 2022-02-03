using SaveCars.ApplicationService.Request.Fabricator;
using SaveCars.ApplicationService.Response;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IFabricatorService : IBaseService<FabricatorRequest, FabricatorSearchRequest, FabricatorResponse>
    {
    }
}

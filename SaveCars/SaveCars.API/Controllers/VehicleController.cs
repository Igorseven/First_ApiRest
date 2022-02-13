using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SaveCars.ApplicationService.Interfaces.Service;
using SaveCars.ApplicationService.Request.Vehicle;
using SaveCars.ApplicationService.Response;
using SaveCars.Business.NotificationSettings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SaveCars.API.Controllers
{
    [Route("api/v1/Vechicle")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            this._vehicleService = vehicleService;
        }

        [HttpGet]
        [Route("findAll")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IEnumerable<DomainNotification>))]
        public async Task<SearchResponse<VehicleResponse>> Get()
        {
            return await this._vehicleService.FindAllAsync();
        }

        [HttpGet]
        [Route("find")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IEnumerable<DomainNotification>))]
        public async Task<VehicleResponse> Get(int vehicleId)
        {
            return await this._vehicleService.FindByAsync(vehicleId);
        }

        [HttpPost]
        [Route("save")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IEnumerable<DomainNotification>))]
        public async Task<int> Post([FromBody] VehicleSaveRequest saveRequest)
        {
            return await this._vehicleService.SaveAsync(saveRequest);
        }

        [HttpPut]
        [Route("update")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IEnumerable<DomainNotification>))]
        public async Task<int> Put([FromBody] VehicleUpdateRequest updateRequest)
        {
            return await this._vehicleService.UpdateAsync(updateRequest);
        }

        [HttpDelete]
        [Route("delete")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IEnumerable<DomainNotification>))]
        public async Task<int> Delete(int VehicleId)
        {
            return await this._vehicleService.DeleteAsync(VehicleId);
        }

        
    }
}

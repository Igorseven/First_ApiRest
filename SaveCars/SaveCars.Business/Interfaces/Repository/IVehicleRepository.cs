using SaveCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaveCars.Business.Interfaces.Repository
{
    public interface IVehicleRepository : IBaseRepository<Vehicle, int>
    {
        Task<IEnumerable<Vehicle>> FindVehiclesAndAllTheDetailsAsync(params Expression<Func<Vehicle, object>>[] includeProperties);
        Task<Vehicle> FindVehicleAndDatailsAsync(Expression<Func<Vehicle, bool>> where, params Expression<Func<Vehicle, object>>[] includeProperties);
    }
}

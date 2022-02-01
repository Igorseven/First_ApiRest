using Microsoft.EntityFrameworkCore;
using SaveCars.Business.Interfaces.Repository;
using SaveCars.Data.EntityFramework.Context;
using SaveCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SaveCars.Data.Repository
{
    public class VehicleRepository : BaseRepository<Vehicle, int>, IVehicleRepository
    {
        public VehicleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<Vehicle> FindVehicleAndDatailsAsync(Expression<Func<Vehicle, bool>> where, params Expression<Func<Vehicle, object>>[] includeProperties)
        {
            return await GetAssociation(includeProperties).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Vehicle>> FindVehiclesAndAllTheDetailsAsync(params Expression<Func<Vehicle, object>>[] includeProperties)
        {
            return await GetAssociation(includeProperties).ToListAsync();
        }
    }
}

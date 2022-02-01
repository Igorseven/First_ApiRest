using SaveCars.Business.Interfaces.Repository;
using SaveCars.Data.EntityFramework.Context;
using SaveCars.Domain.Entities;

namespace SaveCars.Data.Repository
{
    public class FabricatorRepository : BaseRepository<Fabricator, int>, IFabricatorRepository
    {
        public FabricatorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

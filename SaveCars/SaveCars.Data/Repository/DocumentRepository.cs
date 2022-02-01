using SaveCars.Business.Interfaces.Repository;
using SaveCars.Data.EntityFramework.Context;
using SaveCars.Domain.Entities;

namespace SaveCars.Data.Repository
{
    public class DocumentRepository : BaseRepository<Document, int>, IDocumentRepository
    {
        public DocumentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}

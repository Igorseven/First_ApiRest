using SaveCars.ApplicationService.Request.Document;
using SaveCars.ApplicationService.Response;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IDocumentService : IBaseService<DocumentRequest, DocumentSearchRequest, DocumentResponse>
    {
    }
}

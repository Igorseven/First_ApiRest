using SaveCars.ApplicationService.Response;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IBaseService<TRequest, TSearchRequest, TResponse> 
        where TRequest : class
        where TResponse : class 
        where TSearchRequest : class
    {
        Task SaveAsync(TRequest request);
        Task UpdateAsync(TRequest request);
        Task DeleteAsync(TRequest request);

        Task<TResponse> FindByAsync(int id);
        Task<TResponse> FindByAsync(TRequest request);
        Task<SearchResponse<TResponse>> FindAllAsync(TSearchRequest searchRequest);
    }
}

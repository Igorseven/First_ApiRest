using SaveCars.ApplicationService.Response;
using System.Threading.Tasks;

namespace SaveCars.ApplicationService.Interfaces.Service
{
    public interface IBaseService<TRequest, TUpdateRequest, TSearchRequest, TResponse> 
        where TRequest : class
        where TResponse : class 
        where TSearchRequest : class
    {
        Task<int> SaveAsync(TRequest request);
        Task<int> UpdateAsync(TUpdateRequest request);
        Task<int> DeleteAsync(int id);

        Task<TResponse> FindByAsync(int id);
        Task<TResponse> FindByAsync(TSearchRequest searchRequest);
        Task<SearchResponse<TResponse>> FindAllAsync();
    }
}

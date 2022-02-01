using SaveCars.Business.Validation;
using System.Threading.Tasks;

namespace SaveCars.Business.Interfaces.ValidationHandler
{
    public interface IValidation<TEntity> where TEntity : class
    {
        ValidationResponse Validation(TEntity entity);
        Task<ValidationResponse> ValidationAsync(TEntity entity);
    }
}

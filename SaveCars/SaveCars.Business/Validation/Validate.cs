using FluentValidation;
using FluentValidation.Results;
using SaveCars.Business.Interfaces.ValidationHandler;
using SaveCars.Domain.Extention;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveCars.Business.Validation
{
    public class Validate<TEntity> : AbstractValidator<TEntity>, IValidation<TEntity> where TEntity : class
    {

        private ValidationResult ValidationResult { get; set; }

        private Dictionary<string, string> GetErrors() => ValidationResult.Errors.ToDictionary();
        private void CreateResult(TEntity entity) => this.ValidationResult = base.Validate(entity);
        private async Task CreateResultAsync(TEntity entity) => this.ValidationResult = await ValidateAsync(entity);


        public ValidationResponse Validation(TEntity entity)
        {
            CreateResult(entity);
            return ValidationResponse.CreateValidation(GetErrors());
        }

        public async Task<ValidationResponse> ValidationAsync(TEntity entity)
        {
            await CreateResultAsync(entity);
            return ValidationResponse.CreateValidation(GetErrors());
        }
    }
}

using FluentValidation;
using SaveCars.Domain.Entities;
using SaveCars.Domain.Enums;
using SaveCars.Domain.Extention;

namespace SaveCars.Business.Validation.EntitiesValidation
{
    public class VehicleValidation : Validate<Vehicle>
    {
        public VehicleValidation()
        {
            RuleOfProperty();
        }

        private void RuleOfProperty()
        {
            RuleFor(v => v.Model).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Model).Length(2, 50).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Model", "2 a 50"));

            RuleFor(v => v.Information).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Information).Length(3, 200).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Information", "3 a 200"));

            RuleFor(v => v.Price).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Price).GreaterThan(0).WithMessage(EMessage.ValueExpected
                .GetDescription().ToFormatMessage("Price", "0,00"));
        }
    }
}

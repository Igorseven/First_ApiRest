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
            RuleFor(f => f.Fabricator).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(f => f.Fabricator).Length(2, 50).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Fabricator", "2 a 50"));

            RuleFor(v => v.Model).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Model).Length(2, 50).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Model", "2 a 50"));

            RuleFor(v => v.Information).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Information).Length(3, 200).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Information", "3 a 200"));

            RuleFor(v => v.VehiclePlate).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.VehiclePlate).Length(8).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Vehicle plate", "8"));

            RuleFor(v => v.Year).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Year).Length(4, 9).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Year", "4 a 9"));

            RuleFor(v => v.Price).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(v => v.Price).GreaterThan(0).WithMessage(EMessage.ValueExpected
                .GetDescription().ToFormatMessage("Price", "0.00"));
        }
    }
}

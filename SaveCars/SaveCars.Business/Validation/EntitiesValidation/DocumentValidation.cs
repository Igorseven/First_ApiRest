using FluentValidation;
using SaveCars.Domain.Entities;
using SaveCars.Domain.Enums;
using SaveCars.Domain.Extention;

namespace SaveCars.Business.Validation.EntitiesValidation
{
    public class DocumentValidation : Validate<Document>
    {
        public DocumentValidation()
        {
            RuleOfProperty();
        }

        private void RuleOfProperty()
        {
            RuleFor(d => d.DocumentNumber).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(d => d.DocumentNumber).Length(12).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Documente number", "12"));

            RuleFor(d => d.VehiclePlate).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(d => d.VehiclePlate).Length(8).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Vehicle plate", "8"));

            RuleFor(d => d.Tax).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(d => d.Tax).GreaterThan(0).WithMessage(EMessage.ValueExpected
                .GetDescription().ToFormatMessage("Tax", "0,00"));
        }
    }
}

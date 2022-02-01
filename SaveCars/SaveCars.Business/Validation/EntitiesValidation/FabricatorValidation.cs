using FluentValidation;
using SaveCars.Domain.Entities;
using SaveCars.Domain.Enums;
using SaveCars.Domain.Extention;

namespace SaveCars.Business.Validation.EntitiesValidation
{
    public class FabricatorValidation : Validate<Fabricator>
    {
        public FabricatorValidation()
        {
            RuleOfProperty();
        }

        private void RuleOfProperty()
        {
            RuleFor(f => f.Name).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(f => f.Name).Length(2, 50).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Name", "2 a 50"));

            RuleFor(f => f.Nationality).NotEmpty().WithMessage(EMessage.Required.GetDescription());
            RuleFor(f => f.Nationality).Length(3, 70).WithMessage(EMessage.MoreExpected
                .GetDescription().ToFormatMessage("Notionality", "3 a 70"));
        }
    }
}

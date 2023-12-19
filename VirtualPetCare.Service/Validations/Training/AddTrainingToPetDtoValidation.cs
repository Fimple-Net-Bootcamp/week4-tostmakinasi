using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.PetSpecies;
using VirtualPetCare.Core.DTOs.Training;

namespace VirtualPetCare.Service.Validations.Training
{
    public class AddTrainingToPetDtoValidation : AbstractValidator<AddTrainingToPetDto>
    {
        public AddTrainingToPetDtoValidation()
        {
            RuleFor(x=> x.PetId).NotNull().InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0!");
            RuleFor(x=> x.TrainingId).NotNull().InclusiveBetween(1, int.MaxValue).WithMessage("{PropertyName} must be greater 0!");
            RuleFor(x => x.Date).NotNull().NotEmpty().WithMessage("{PropertyName} required!").GreaterThanOrEqualTo(DateTime.UtcNow.Date);
            
        }
    }
}

using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPetCare.Core.DTOs.SocialInteraction;

namespace VirtualPetCare.Service.Validations.SocialInteraction
{/*public string Title { get; set; }
        public string Description { get; set; }
        public List<ParticipantListDto> Paticipants{ get; set; }*/
    public class SocialInteractionCreateDtoValidation :  AbstractValidator<SocialInteractionCreateDto>
    {
        public SocialInteractionCreateDtoValidation()
        {
            RuleFor(x=> x.Title).NotEmpty().NotNull().WithMessage("{PropertyName} required!");

        }
    }
}

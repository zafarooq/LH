using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using ListerHaigh.Models;
namespace ListerHaigh.Models.Validators.Events
{
    public class EventValidator : AbstractValidator<EventModel>
    {
        public EventValidator() { 
            RuleFor(x=>x.Code)
                .NotEmpty().WithMessage("Code field is required.")
                .Length(1, 50).WithMessage("Code cannot be greater than 50.");

            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name field is required")
                .Length(1, 50).WithMessage("Name cannot be greater than 50.");
        }
    }
}

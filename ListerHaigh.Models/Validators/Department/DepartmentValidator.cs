using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListerHaigh.Models;
using FluentValidation;
namespace ListerHaigh.Validators
{
    public class DepartmentValidator : AbstractValidator<DepartmentModel>
    {
        public DepartmentValidator()
        {
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Code is a required field.")
                .Length(1, 50).WithMessage("Code cannot be greater than 50.");
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name field is required")
                .Length(1, 50).WithMessage("Name cannot be greater than 50.");
        }
    }
}

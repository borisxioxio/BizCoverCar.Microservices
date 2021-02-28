using Cars.API.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.API.Validations
{
    public class UpdateCarValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarValidator()
        {
            RuleFor(x => x.id).NotEmpty();
            RuleFor(x => x.make).NotEmpty();
            RuleFor(x => x.model).NotEmpty();
            RuleFor(x => x.year).NotEmpty();
            RuleFor(x => x.countryManufactured).NotEmpty();
            RuleFor(x => x.colour).NotEmpty();
            RuleFor(x => x.price).NotEmpty();
        }
    }
}

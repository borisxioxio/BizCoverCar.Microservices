using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.API.Commands;
using FluentValidation;
namespace Cars.API.Validations
{
    public class AddCarValidator:AbstractValidator<AddCarCommand>
    {
        public AddCarValidator()
        {
            RuleFor(x => x.make).NotEmpty();
            RuleFor(x => x.model).NotEmpty();
            RuleFor(x => x.year).NotEmpty();
            RuleFor(x => x.countryManufactured).NotEmpty();
            RuleFor(x => x.colour).NotEmpty();
            RuleFor(x => x.price).NotEmpty();
        }
    }
}

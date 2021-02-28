using Cars.API.DTO;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.API.Commands
{
    public class AddCarCommand : IRequest<AddCarResponse>
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string countryManufactured { get; set; }
        public string colour { get; set; }
        public decimal price { get; set; }
    }

    public class AddCarResponse
    {
        public bool Success { get; set; }
        public int? Id { get; set; }
    }
}

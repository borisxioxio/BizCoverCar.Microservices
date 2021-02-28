using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cars.API.DTO;
using MediatR;
namespace Cars.API.Commands
{
    public class UpdateCarCommand: CarDto, IRequest<UpdateCarResponse>
    {
        
    }

    public class UpdateCarResponse
    {
        public bool Success { get; set; }
        public string? Message { get; set; }
    }
}

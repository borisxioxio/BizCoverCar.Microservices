using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Cars.API.Queries;
using Cars.API.Commands;
using Cars.API.DTO;

namespace Cars.API.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            GetAllCarsQuery getAllCarsQuery = new GetAllCarsQuery();
            var rs  = await _mediator.Send(getAllCarsQuery);
            return rs != null ?Ok(rs) :NotFound();
        }

        [HttpPost("update")]
        public async Task<IActionResult> Update(UpdateCarCommand updateCarCommand)
        {
            var rs = await _mediator.Send(updateCarCommand);
            return rs != null ? Ok(rs) : NotFound();
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(AddCarCommand addCarCommand)
        {
            var rs = await _mediator.Send(addCarCommand);
            return rs != null ? Ok(rs) : NotFound();
        }
    }
}
